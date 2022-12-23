using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

using TDI = TypeDetailIndex;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindDetails : ResultPreviewerBase
{
    /// <summary>
    /// グローバル スタックの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_GLOBAL_MANAGER =
        "グローバル スタックへのリンクが設定されていません。";

    /// <summary>既定の表示コンテンツ。</summary>
    private readonly string[] defaultContents = new[] { string.Empty };

#pragma warning disable IDE0044

    /// <summary>
    /// グローバルにマインドキューブのスタックを管理するクラス。
    /// </summary>
    [SerializeField]
    private GlobalStackManager globalStackManager;

    /// <summary>名前ラベル。</summary>
    [SerializeField]
    private Text nameLabel;
#pragma warning restore IDE0054

    private string GetDetailedGeniusPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        string content = PageGenerator.CreateDetailedGeniusPage(vars.Inner);
        string comingSoon = PageGenerator.CreateComingSoon();
        return $"{content}\n{comingSoon}";
    }

    /// <summary>
    /// 性格の大分類のページの文言を取得します。
    /// </summary>
    /// <returns>性格の大分類のページの文言。</returns>
    private string GetGeniusPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        byte genius = MasterData.DetailsMap()[vars.Inner][(int)TDI.Genius];
        return PageGenerator.CreateGeniusPage(genius);
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
            Contents = defaultContents;
            UpdateContents();
            return;
        }
        MindCubeVariables cube = globalStackManager.GetMindCubeVariables();
        if (cube == null)
        {
            Contents = defaultContents;
            UpdateContents();
            return;
        }
        if (cube.Parameter == uint.MaxValue)
        {
            Contents = PageGenerator.CreateInvalidCubePage();
            UpdateContents();
            return;
        }
        Contents = new[] { GetGeniusPage(), GetDetailedGeniusPage() };
        nameLabel.text = cube.CubeName;
        UpdateContents();
    }
}
