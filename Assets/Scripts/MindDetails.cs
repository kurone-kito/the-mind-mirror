using TMPro;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindDetails : Observer
{
    /// <summary>
    /// グローバル スタックの接続不備における、エラーメッセージ。
    /// </summary>
    private const string WARN_NO_GLOBAL_MANAGER =
        "グローバル スタックへのリンクが設定されていません。";

#pragma warning disable IDE0044
#pragma warning disable IDE0051
    /// <summary>本文ラベル。</summary>
    [SerializeField]
    private TextMeshPro details;
#pragma warning restore IDE0051

    /// <summary>
    /// グローバルにマインドキューブのスタックを管理するクラス。
    /// </summary>
    [SerializeField]
    private GlobalStackManager globalStackManager;

#pragma warning disable IDE0051
    /// <summary>名前ラベル。</summary>
    [SerializeField]
    private Text nameLabel;
#pragma warning restore IDE0051

    /// <summary>ページネーションのラベル。</summary>
    [SerializeField]
    private TextMeshPro paginationLabel;
#pragma warning restore IDE0044

    /// <summary>
    /// 次のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushNext()
    {
        paginationLabel.text = "Next";
        Debug.Log("OnPushNext");
    }

    /// <summary>
    /// 前のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushPrevious()
    {
        paginationLabel.text = "Prev";
        Debug.Log("OnPushPrevious");
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    public override void OnNotify()
    {
        base.OnNotify();
        if (globalStackManager == null)
        {
            Debug.LogWarning(WARN_NO_GLOBAL_MANAGER);
            return;
        }
        MindCubeVariables cube = globalStackManager.GetMindCubeVariables();
        if (cube == null)
        {
            return;
        }
        nameLabel.text = cube.CubeName;
    }
}
