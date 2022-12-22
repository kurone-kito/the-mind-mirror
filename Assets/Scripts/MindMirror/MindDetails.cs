using TMPro;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

using TDI = TypeDetailIndex;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindDetails : ResourcesObserver
{
    /// <summary>
    /// グローバル スタックの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_GLOBAL_MANAGER =
        "グローバル スタックへのリンクが設定されていません。";

    /// <summary>既定の表示コンテンツ。</summary>
    private readonly string[] defaultContents = new[] { string.Empty };

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
    private string[] contents = new[] { string.Empty };

    /// <summary>現在のページ番号。</summary>
    private int currentPage = 0;

    /// <summary>テキスト リソース群へのアクセサー。</summary>
    private ResourcesManager resourcesManager;

    /// <summary>テキスト リソース群へのアクセサーを取得します。</summary>
    private ResourcesManager ResourcesManager =>
#pragma warning disable IDE0054
        resourcesManager =
            resourcesManager ?? ResourcesManager.GetInstance();
#pragma warning restore IDE0054

    /// <summary>
    /// 次のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushNext()
    {
        currentPage = (currentPage + 1) % contents.Length;
        UpdateContents();
    }

    /// <summary>
    /// 前のページ ボタンを謳歌した際に呼び出す、コールバック。
    /// </summary>
    public void OnPushPrevious()
    {
        int pageCount = contents.Length;
        currentPage = (currentPage + pageCount - 1) % pageCount;
        UpdateContents();
    }

    /// <summary>描画状態を更新します。</summary>
    private void UpdateContents()
    {
        paginationLabel.text = ResourcesManager.Resources.GetPages(
            currentPage + 1, contents.Length);
        details.text = contents[currentPage];
    }

    /// <summary>
    /// 性格の大分類のページの文言を取得します。
    /// </summary>
    /// <returns>性格の大分類のページの文言。</returns>
    private string GetGeniusPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        byte genius = MasterData.DetailsMap()[vars.Inner][(int)TDI.Genius];
        string content = PageGenerator.CreateGeniusPage(genius);
        string comingSoon = PageGenerator.CreateComingSoon();
        return $"{content}\n{comingSoon}";
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="subject">呼び出し元のサブジェクト。</param>
    public override void OnNotify(Subject subject)
    {
        base.OnNotify(subject);
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
            contents = PageGenerator.CreateInvalidCubePage();
            UpdateContents();
            return;
        }
        contents = new[] { GetGeniusPage() };
        nameLabel.text = cube.CubeName;
        UpdateContents();
    }
}
