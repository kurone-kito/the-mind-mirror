
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>レンダラーのインデックス一覧。</summary>
internal enum RendererIndex
{
    /// <summary>大まかな性格指向。</summary>
    Vector = 0,
    /// <summary>内面的な素質。</summary>
    InnerA = 1,
    /// <summary>内面的な素質。</summary>
    InnerB = 2,
    /// <summary>外面的な素質。</summary>
    Outer = 3,
    /// <summary>緊急時・集中時の素質。</summary>
    WorkStyle = 4,
    /// <summary>サイクル。</summary>
    Cycle = 5,
    /// <summary>ライフベース。</summary>
    LifeBase = 6,
    /// <summary>ポテンシャル A。</summary>
    PotentialA = 7,
    /// <summary>ポテンシャル B。</summary>
    PotentialB = 8,
}

/// <summary>マインドキューブのプール。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class MindCubeVariables : SyncBase
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
    public uint parameter = 0u;

#pragma warning disable IDE0044
    /// <summary>オブジェクトのレンダラー一覧。</summary>
    [SerializeField]
    private Renderer[] renderers;
#pragma warning restore IDE0044

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
            UpdateColor();
        }
    }

    /// <summary>色のレンダリング状態を更新します。</summary>
    public void UpdateColor()
    {
        if (renderers == null)
        {
            Debug.LogWarning(ERR_NO_RENDERER);
            return;
        }
        byte inner = PersonalityParamsPacker.UnPackInner(Parameter);
        UpdateColor(
            RendererIndex.Vector,
            (byte)UnityEngine.Random.Range(0, 0xF));
        UpdateColor(RendererIndex.InnerA, inner);
        UpdateColor(RendererIndex.InnerB, inner);
        UpdateColor(
            RendererIndex.Outer,
            PersonalityParamsPacker.UnPackOuter(Parameter));
        UpdateColor(
            RendererIndex.WorkStyle,
            PersonalityParamsPacker.UnPackWorkStyle(Parameter));
        UpdateColor(
            RendererIndex.Cycle,
            PersonalityParamsPacker.UnPackCycle(Parameter));
        UpdateColor(
            RendererIndex.LifeBase,
            PersonalityParamsPacker.UnPackLifeBase(Parameter));
        UpdateColor(
            RendererIndex.PotentialA,
            PersonalityParamsPacker.UnPackPotentialA(Parameter));
        UpdateColor(
            RendererIndex.PotentialB,
            PersonalityParamsPacker.UnPackPotentialB(Parameter));
    }

    /// <summary>色のレンダリング状態を更新します。</summary>
    /// <param name="index">レンダラーのインデックス。</param>
    /// <param name="value">0～16 で表現する、色相値。</param>
    private void UpdateColor(RendererIndex index, byte value)
    {
        if (renderers[(int)index] == null)
        {
            Debug.LogWarning(ERR_NO_RENDERER);
            return;
        }
        renderers[(int)index].material.color =
            Color.HSVToRGB(value % 16 / 16f, 1f, 1f);
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
        UpdateColor();
    }
}
