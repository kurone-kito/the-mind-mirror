
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>マインド スフィア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MindSphere : Observer
{
    /// <summary>
    /// 相性ラインまたは他のスフィアへの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_LINE_OR_SPHERE =
        "相性ラインまたは他のスフィアへのリンクが設定されていません。";

    /// <summary>回転角のオフセット。</summary>
    private const float OFFSET = 15f;

    /// <summary>性格の内面タイプ毎の、位置移動のための回転量。</summary>
    private readonly int[] rotationByInner =
        { 0, 1, 5, 10, 11, 6, 2, 9, 7, 8, 4, 3 };

#pragma warning disable IDE0044
    /// <summary>相性ライン一覧。</summary>
    [SerializeField]
    private AffinityLine[] lines;

    /// <summary>名前ラベル。</summary>
    [SerializeField]
    private Text nameLabel;

    /// <summary>他のスフィア一覧。</summary>
    [SerializeField]
    private MindSphere[] others;
#pragma warning restore IDE0044

    /// <summary>内面的な素質を取得します。</summary>
    public byte Inner { get; private set; }

    /// <summary>1 フレーム後に、相性ラインを更新します。</summary>
    /// <remarks>
    /// このメソッドは、他のスフィアの状態が変化した際にも呼び出します。
    /// </remarks>
    public void ReserveUpdateLine()
    {
        SendCustomEventDelayedFrames(nameof(UpdateLine), 1);
    }

    /// <summary>相性ラインを更新します。</summary>
    public void UpdateLine()
    {
        if (
            lines == null ||
            others == null ||
            lines.Length != others.Length
        )
        {
            Debug.LogWarning(ERR_NO_LINE_OR_SPHERE);
            return;
        }
        for (int i = lines.Length; --i >= 0;)
        {
            bool active =
                gameObject.activeSelf && others[i].gameObject.activeSelf;
            lines[i].gameObject.SetActive(active);
            if (!active)
            {
                continue;
            }
            Vector3 p = others[i].transform.position;
            // p.y = 1f;
            lines[i].Target = p;
            lines[i].Level = MasterData.Biz()[Inner][others[i].Inner];
        }
    }

    /// <summary>マインドキューブ情報を取得します。</summary>
    /// <param name="stack">
    /// マインドキューブを一時預かりするスタック オブジェクト。
    /// </param>
    /// <returns>マインドキューブ情報。</returns>
    private MindCubeVariables GetVars(MindStack stack)
    {
#pragma warning disable IDE0031
        MindCube cube = stack == null ? null : stack.MindCube;
        return cube == null ? null : cube.Variables;
#pragma warning restore IDE0031
    }

    /// <summary>名前情報を更新します。</summary>
    /// <param name="stack">
    /// マインドキューブを一時預かりするスタック オブジェクト。
    /// </param>
    private void UpdateName(MindStack stack)
    {
        MindCubeVariables vars = GetVars(stack);
#pragma warning disable IDE0031
        string name = vars == null || vars.Empty ? null : vars.CubeName;
#pragma warning restore IDE0031
        nameLabel.text = name ?? string.Empty;
        bool active = !string.IsNullOrEmpty(name);
        gameObject.SetActive(active);
        Inner = active ? vars.Inner : byte.MaxValue;
        if (active)
        {
            UpdatePosition();
        }
    }

    /// <summary>
    /// マインド スフィアの位置を更新します。
    /// </summary>
    private void UpdatePosition()
    {
        float baseRotate = rotationByInner[Inner];
        float gap = OFFSET * Random.Range(-0.5f, 0.5f);
        float rotate = OFFSET + (baseRotate * 30f) + gap;
        Quaternion q = Quaternion.AngleAxis(rotate, Vector3.up);
        transform.localPosition =
            q * Vector3.left * Random.Range(2f, 4f);
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="subject">サブジェクト本体。</param>
    public override void OnNotify(Subject subject)
    {
        if (subject == null)
        {
            return;
        }
        UpdateName(subject.GetComponent<MindStack>());
        ReserveUpdateLine();
        foreach (MindSphere sphere in others ?? new MindSphere[0])
        {
            sphere.ReserveUpdateLine();
        }
    }
}
