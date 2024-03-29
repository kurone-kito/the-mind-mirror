using TMPro;
using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブの情報ビューアの基底機能。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public abstract class ResultPreviewerBase : ResourcesObserver
{
#pragma warning disable IDE0044
    /// <summary>本文ラベル。</summary>
    [SerializeField]
    private TextMeshProUGUI main;

    /// <summary>ページ ラベル。</summary>
    [SerializeField]
    private TextMeshProUGUI page;
#pragma warning restore IDE0044

    /// <summary>現在のページ番号。</summary>
    private int currentPage = 0;

    /// <summary>表示コンテンツ。</summary>
    protected string[] Contents { get; set; } = new[] { string.Empty };


    /// <summary>
    /// 次のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushNext()
    {
        currentPage = (currentPage + 1) % Contents.Length;
        UpdateContents();
    }

    /// <summary>
    /// 前のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushPrevious()
    {
        int pageCount = Contents.Length;
        currentPage = (currentPage + pageCount - 1) % pageCount;
        UpdateContents();
    }

    /// <summary>ページ番号をリセットします。</summary>
    protected void ResetPage()
    {
        currentPage = 0;
    }

    /// <summary>描画状態を更新します。</summary>
    protected virtual void UpdateContents()
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        if (main == null || page == null || res == null)
        {
            return;
        }
        page.text =
            string.Format(
                res.TemplatePages, currentPage + 1, Contents.Length);
        main.text =
            currentPage >= Contents.Length ? string.Empty :
            Contents[currentPage];
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="subject">呼び出し元のサブジェクト。</param>
    public override void OnNotify(Subject subject)
    {
        base.OnNotify(subject);
        UpdateContents();
    }
}
