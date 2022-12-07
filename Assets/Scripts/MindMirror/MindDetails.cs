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
    private const string ERR_NO_GLOBAL_MANAGER =
        "グローバル スタックへのリンクが設定されていません。";

    /// <summary>
    /// マインドキューブの状態不備における、エラーメッセージ。
    /// </summary>
    private const string WARN_INSERTED_THE_EMPTY_MIND_CUBE =
        @"<align=""center"">診断するマインドキューブが抜け殻のようで、診断ができません。
<align=""center"">お隣の部屋のマインドライターで魂の情報を書き込んでから、再度お試しください。";

    /// <summary>未実装メッセージ。</summary>
    private const string INFO_COMING_SOON =
        @"<align=""center"">COMING SOON...

<align=""center"">マインドビューア(暫定版)を
<align=""center"">ご利用ください。";

    /// <summary>既定の表示コンテンツ。</summary>
    private readonly string[] defaultContents =
        new string[] { string.Empty };

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

    /// <summary>名前ラベル。</summary>
    [SerializeField]
    private Text nameLabel;

    /// <summary>ページネーションのラベル。</summary>
    [SerializeField]
    private TextMeshPro paginationLabel;
#pragma warning restore IDE0044

    /// <summary>表示コンテンツ。</summary>
    private string[] contents = new string[] { string.Empty };

    /// <summary>現在のページ番号。</summary>
    private int currentPage = 0;

    /// <summary>
    /// 次のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushNext()
    {
        currentPage = (currentPage + 1) % contents.Length;
        Debug.Log("OnPushNext");
        UpdateContents();
    }

    /// <summary>
    /// 前のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushPrevious()
    {
        int pageCount = contents.Length;
        currentPage = (currentPage + pageCount - 1) % pageCount;
        Debug.Log("OnPushPrevious");
        UpdateContents();
    }

    /// <summary>描画状態を更新します。</summary>
    private void UpdateContents()
    {
        paginationLabel.text =
            $"{currentPage + 1}/{contents.Length} ページ";
        details.text = contents[currentPage];
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    public override void OnNotify()
    {
        base.OnNotify();
        if (globalStackManager == null)
        {
            Debug.LogWarning(ERR_NO_GLOBAL_MANAGER);
            contents = defaultContents;
            UpdateContents();
            return;
        }
        MindCubeVariables cube = globalStackManager.GetMindCubeVariables();
        if (cube == null)
        {
            contents = defaultContents;
            UpdateContents();
            return;
        }
        if (cube.Parameter == uint.MaxValue)
        {
            contents = new string[] { WARN_INSERTED_THE_EMPTY_MIND_CUBE };
            UpdateContents();
            return;
        }
        contents = new string[] { INFO_COMING_SOON };
        nameLabel.text = cube.CubeName;
        UpdateContents();
    }
}
