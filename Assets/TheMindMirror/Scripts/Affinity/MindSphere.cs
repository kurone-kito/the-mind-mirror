
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;

/// <summary>マインド スフィア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MindSphere : Observer
{
    /// <summary>回転角のオフセット。</summary>
    private const float OFFSET = 15f;

    /// <summary>性格の内面タイプ毎の、位置移動のための回転量。</summary>
    private readonly int[] rotationByInner =
        { 0, 1, 5, 10, 11, 6, 2, 9, 7, 8, 4, 3 };

#pragma warning disable IDE0044
    /// <summary>名前ラベル。</summary>
    [SerializeField]
    private Text nameLabel;
#pragma warning restore IDE0044

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
        if (active)
        {
            UpdatePosition(vars.Inner);
        }
    }

    /// <summary>
    /// マインド スフィアの位置を更新します。
    /// </summary>
    /// <param name="inner">内面的な素質。</param>
    private void UpdatePosition(byte inner)
    {
        float baseRotate = rotationByInner[inner];
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
    }

#pragma warning disable IDE0051
    /// <summary>毎フレーム呼び出す、コールバック。</summary>
    private void Update()
    {
        VRCPlayerApi player = Networking.LocalPlayer;
        if (player == null)
        {
            return;
        }
        VRCPlayerApi.TrackingData data =
            player.GetTrackingData(VRCPlayerApi.TrackingDataType.Head);
#pragma warning disable IDE0090
        Vector3 v = new Vector3(0f, data.rotation.eulerAngles.y, 0f);
#pragma warning restore IDE0090
        nameLabel.transform.localRotation = Quaternion.Euler(v);
    }
#pragma warning restore IDE0051
}
