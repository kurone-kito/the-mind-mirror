using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

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

    /// <summary>3 種類の素質ページの文言を取得します。</summary>
    /// <returns>3 種類の素質ページの文言。</returns>
    private string Get3TypedGeniusPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return res.Create3GeniusPage(vars.Inner, vars.Outer, vars.WorkStyle);
    }

    /// <summary>論理思考タイプページの文言を取得します。</summary>
    /// <returns>論理思考タイプページの文言。</returns>
    private string GetBrainsPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        byte[] dt = MasterData.DetailsMap()[vars.Inner];
        return res.BuiltBrains[dt[(int)TypeDetailIndex.Brain]];
    }

    /// <summary>素質ページの文言を取得します。</summary>
    /// <returns>素質ページの文言。</returns>
    private string GetDetailedGeniusPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return res.BuiltDetailedGeniusType[vars.Inner];
    }

    /// <summary>素質毎に対する攻略法ページの文言を取得します。</summary>
    /// <returns>素質毎に対する攻略法ページの文言。</returns>
    private string GetDetailedGeniusStrategyPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return res.BuiltDetailedGeniusStrategy[vars.Inner];
    }

    /// <summary>素質毎の弱点ページの文言を取得します。</summary>
    /// <returns>素質毎の弱点ページの文言。</returns>
    private string GetDetailedGeniusWeaknessPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return res.BuiltDetailedGeniusWeakness[vars.Inner];
    }

    /// <summary>性格の大分類のページの文言を取得します。</summary>
    /// <returns>性格の大分類のページの文言。</returns>
    private string GetGeniusPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        byte[] details = MasterData.DetailsMap()[vars.Inner];
        return res.BuiltGenius[details[(int)TypeDetailIndex.Genius]];
    }

    /// <summary>性格の大分類別の攻略法ページの文言を取得します。</summary>
    /// <returns>性格の大分類別の攻略法ページの文言。</returns>
    private string GetGeniusStrategyPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        byte[] details = MasterData.DetailsMap()[vars.Inner];
        return res.BuiltGeniusStrategy[details[(int)TypeDetailIndex.Genius]];
    }

    /// <summary>人生観ページの文言を取得します。</summary>
    /// <returns>人生観ページの文言。</returns>
    private string GetLifeBasePage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return res.BuiltLifebase[vars.LifeBase];
    }

    /// <summary>潜在能力ページの文言を取得します。</summary>
    /// <returns>潜在能力ページの文言。</returns>
    private string GetPotentialPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return res.BuiltPotentials[vars.PotentialA][vars.PotentialB];
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="subject">呼び出し元のサブジェクト。</param>
    public override void OnNotify(Subject subject)
    {
        if (
            subject != null &&
            subject.name == "MindMirrorSubject"
        )
        {
            ResetPage();
        }
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
        if (cube.Empty)
        {
            Contents = PageGenerator.CreateInvalidCubePage();
            UpdateContents();
            return;
        }
        string comingSoon = PageGenerator.CreateComingSoon();
        Contents =
            new[]
            {
                GetGeniusPage(),
                GetGeniusStrategyPage(),
                GetDetailedGeniusPage(),
                GetDetailedGeniusWeaknessPage(),
                GetDetailedGeniusStrategyPage(),
                Get3TypedGeniusPage(),
                GetBrainsPage(),
                GetLifeBasePage(),
                $"{GetPotentialPage()}\n{comingSoon}",
            };
        nameLabel.text = cube.CubeName;
        UpdateContents();
    }
}
