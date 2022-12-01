using TMPro;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindDetails : UdonSharpBehaviour
{
#pragma warning disable IDE0044
#pragma warning disable IDE0051
    /// <summary>本文ラベル。</summary>
    [SerializeField]
    private TextMeshPro details;

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
}
