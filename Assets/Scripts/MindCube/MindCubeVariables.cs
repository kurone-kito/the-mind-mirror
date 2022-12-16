using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>レンダラーのインデックス一覧。</summary>
internal enum RendererIndex
{
    /// <summary>大まかな性格指向。</summary>
    Vector,
    /// <summary>内面的な素質。</summary>
    InnerA,
    /// <summary>内面的な素質。</summary>
    InnerB,
    /// <summary>外面的な素質。</summary>
    Outer,
    /// <summary>緊急時・集中時の素質。</summary>
    WorkStyle,
    /// <summary>サイクル。</summary>
    Cycle,
    /// <summary>ライフベース。</summary>
    LifeBase,
    /// <summary>ポテンシャル A。</summary>
    PotentialA,
    /// <summary>ポテンシャル B。</summary>
    PotentialB,
}

/// <summary>マインドキューブにおける、同期的変数の管理クラス。</summary>
/// <remarks>
/// ルート オブジェクトは VRCObjectSync が繋がっていることから連続的な同期
/// が必要で、通信のパフォーマンス低下対策のために子オブジェクトに分割し、
/// 必然的にビヘイビアクラスもこのように分離しています。
/// </remarks>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindCubeVariables : SyncBase
{
    /// <summary>
    /// 名前ラベルの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_LABEL = "名前ラベルへのリンクが設定されていません。";

    /// <summary>
    /// レンダラーの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_RENDERER =
        "レンダラーへのリンクが設定されていません。";

    /// <summary>キューブに刻む名前。</summary>
    [NonSerialized, UdonSynced, FieldChangeCallback(nameof(CubeName))]
    public string cubeName = string.Empty;

#pragma warning disable IDE0044
    /// <summary>名前ラベル一覧。</summary>
    [SerializeField]
    private Text[] nameLabels;
#pragma warning restore IDE0044

    /// <summary>パラメーター。</summary>
    [NonSerialized, UdonSynced, FieldChangeCallback(nameof(Parameter))]
    public uint parameter = uint.MaxValue;

#pragma warning disable IDE0044
    /// <summary>オブジェクトのレンダラー一覧。</summary>
    [SerializeField]
    private Renderer[] renderers;
#pragma warning restore IDE0044
    /// <summary>補助的な素質の変化を取得します。</summary>
    public byte Cycle { get; private set; }

    /// <summary>内面的な素質を取得します。</summary>
    public byte Inner { get; private set; }

    /// <summary>根底となる人生観を取得します。</summary>
    public byte LifeBase { get; private set; }

    /// <summary>外面的な素質を取得します。</summary>
    public byte Outer { get; private set; }

    /// <summary>行動を起こす際の潜在能力 A を取得します。</summary>
    public byte PotentialA { get; private set; }

    /// <summary>行動を起こす際の潜在能力 B を取得します。</summary>
    public byte PotentialB { get; private set; }

    /// <summary>大まかな素質タイプを取得します。</summary>
    public byte Genius { get; private set; }

    /// <summary>緊急時・集中時の素質を取得します。</summary>
    public byte WorkStyle { get; private set; }

    /// <summary>キューブに刻む名前を取得、または設定します。</summary>
    public string CubeName
    {
        get => cubeName;
        set
        {
            cubeName = value ?? string.Empty;
            UpdateName();
        }
    }

    /// <summary>パラメーターを取得、または設定します。</summary>
    public uint Parameter
    {
        get => parameter;
        set
        {
            parameter = value;
            DestractParameter();
            UpdateColor();
        }
    }

    private void DestractParameter()
    {
        Cycle = PersonalityParamsPacker.UnPackCycle(parameter);
        Inner = PersonalityParamsPacker.UnPackInner(parameter);
        LifeBase = PersonalityParamsPacker.UnPackLifeBase(parameter);
        Outer = PersonalityParamsPacker.UnPackOuter(parameter);
        PotentialA = PersonalityParamsPacker.UnPackPotentialA(parameter);
        PotentialB = PersonalityParamsPacker.UnPackPotentialB(parameter);
        WorkStyle = PersonalityParamsPacker.UnPackWorkStyle(parameter);
        byte[][] dm = MasterData.DetailsMap();
        Genius = dm[Inner % dm.Length][(int)TypeDetailIndex.Genius];
    }

    /// <summary>色のレンダリング状態を更新します。</summary>
    private void UpdateColor()
    {
        if (renderers == null)
        {
            Debug.LogWarning(ERR_NO_RENDERER);
            return;
        }
        UpdateColor(RendererIndex.Vector, Genius / 3f);
        UpdateColor(RendererIndex.InnerA, Inner / 12f);
        UpdateColor(RendererIndex.InnerB, Inner / 12f);
        UpdateColor(RendererIndex.Outer, Outer / 12f);
        UpdateColor(RendererIndex.WorkStyle, WorkStyle / 12f);
        UpdateColor(RendererIndex.Cycle, Cycle / 10f);
        UpdateColor(RendererIndex.LifeBase, LifeBase / 10f);
        UpdateColor(RendererIndex.PotentialA, PotentialA / 10f);
        UpdateColor(RendererIndex.PotentialB, PotentialB / 10f);
    }

    /// <summary>色のレンダリング状態を更新します。</summary>
    /// <param name="index">レンダラーのインデックス。</param>
    /// <param name="value">0～1 で表現する、色相値。</param>
    private void UpdateColor(RendererIndex index, float value)
    {
        if (renderers[(int)index] == null)
        {
            Debug.LogWarning(ERR_NO_RENDERER);
            return;
        }
        bool init = parameter == uint.MaxValue;
        Color color = Color.HSVToRGB(Mathf.Clamp01(value), 1f, 1f);
        renderers[(int)index].material.color = init ? Color.gray : color;

    }

    /// <summary>名前のレンダリング状態を更新します。</summary>
    public void UpdateName()
    {
        if (nameLabels == null)
        {
            Debug.LogWarning(ERR_NO_LABEL);
            return;
        }
        foreach (Text nameLabel in nameLabels)
        {
            if (nameLabel != null)
            {
                nameLabel.text = CubeName;
            }
        }
    }

    /// <summary>同期変数のアップデートを通知します。</summary>
    protected override void Notify()
    {
        UpdateName();
        DestractParameter();
        UpdateColor();
    }

#pragma warning disable IDE0051
    /// <summary>初期化時に呼び出される、コールバック。</summary>
    private void Start()
    {
        Notify();
    }
#pragma warning restore IDE0051
}
