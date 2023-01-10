using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>役割相性用マインドスタックの名札表示クラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class RoleAffinityNameTag : Observer
{
#pragma warning disable IDE0044
    /// <summary>名前ラベル。</summary>
    [SerializeField]
    private Text nameLabel;
#pragma warning restore IDE0044

    /// <summary>マインドキューブから受け取った名前。</summary>
    private string cubeName;

    /// <summary>
    /// 無効時のローカライズ文言を更新します。
    /// </summary>
    /// <param name="res">テキスト リソース群へのアクセサー。</param>
    private void UpdateLocalize(ResourcesManager res)
    {
        FallbackResources r =
            (res ?? ResourcesManager.GetInstance()).Resources;
#pragma warning disable IDE0031
        string warn =
            r == null ? null : r.WarnOnInsertTheEmptyMindCubeShort;
#pragma warning restore IDE0031
        nameLabel.text =
            string.IsNullOrEmpty(cubeName)
                ? $"<color=\"red\"><i>{warn}</i></color>"
                : cubeName;
    }

    /// <summary>名前情報を更新します。</summary>
    /// <param name="stack">
    /// マインドキューブを一時預かりするスタック オブジェクト。
    /// </param>
    private void UpdateName(MindStack stack)
    {
        if (stack == null)
        {
            return;
        }
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        MindCube cube = stack.MindCube;
#pragma warning disable IDE0031
        string warn =
            res == null ? null : res.WarnOnInsertTheEmptyMindCubeShort;
        MindCubeVariables vars = cube == null ? null : cube.Variables;
        cubeName = vars == null || vars.Empty ? null : vars.CubeName;
#pragma warning restore IDE0031
        nameLabel.text =
            string.IsNullOrEmpty(cubeName) || vars.Empty
                ? $"<color=\"red\"><i>{warn}</i></color>"
                : cubeName;
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
        UpdateLocalize(subject.GetComponent<ResourcesManager>());
    }
}
