using RES = Parameters;
using TDI = TypeDetailIndex;

/// <summary>
/// テキスト リソース データ群。
/// </summary>
public static class PageGenerator
{
    /// <summary>中央寄せ。</summary>
    private const string CENTER = "<align=\"center\">";

    /// <summary>両端揃えの左寄せ。</summary>
    private const string JUSTIFY = "<align=\"justified\">";

    /// <summary>右寄せ。</summary>
    private const string RIGHT = "<align=\"right\">";

    /// <summary>3 種類の素質ページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="genius">素質タイプ。</param>
    /// <returns>3 種類の素質ページの文言。</returns>
    public static string Create3GeniusPage(
        this FallbackResources res,
        int genius)
    {
        return res.Create3GeniusPage(genius, genius, genius);
    }

    /// <summary>3 種類の素質ページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="inner">内面素質タイプ。</param>
    /// <param name="outer">外面素質タイプ。</param>
    /// <param name="workstyle">集中時素質タイプ。</param>
    /// <returns>3 種類の素質ページの文言。</returns>
    public static string Create3GeniusPage(
        this FallbackResources res,
        int inner,
        int outer,
        int workstyle)
    {
        string fixedPart =
            res.Built3TypedGeniusFixedPart ??
            res.Create3GeniusPageFixedPart();
        string[] src =
            "<cspace=-0.1em>{0}</cspace>: <b>{1}</b>; {2}".MapWithFormat(
                new[]
                {
                    res.ThreeTypedGeniusName,
                    new[]
                    {
                        res.DetailedGeniusTypeName[inner],
                        res.DetailedGeniusTypeName[outer],
                        res.DetailedGeniusTypeName[workstyle],
                    },
                    new[]
                    {
                        res.DetailedGeniusTypeSummary[inner],
                        res.DetailedGeniusTypeSummary[outer],
                        res.DetailedGeniusTypeSummary[workstyle],
                    },
                });
        return $"{fixedPart}{res.CreateDetailList(src)}";
    }

    /// <summary>
    /// 3 種類の素質ページの文言のうち、固定部分を取得します。
    /// </summary>
    /// <param name="res">リソース。</param>
    /// <returns>3 種類の素質ページの文言。</returns>
    public static string Create3GeniusPageFixedPart(
        this FallbackResources res)
    {
        string lh = $"<line-height={res.SizeLine}%>";
        string br = $"</line-height>\n<line-height={res.SizeLine / 10}%>\n</line-height>{lh}";
        string thin = "<cspace=-0.1em>";
        string head = $"{thin}<smallcaps>{res.ThreeTypedGeniusHeading}</smallcaps></cspace>";
        string desc1 = $"{JUSTIFY}<size={res.SizeDescription}>{head}> {res.ThreeTypedGeniusDescription[0]}</size>";
        string desc2 = $"{JUSTIFY}<size={res.SizeDescription}>{res.ThreeTypedGeniusDescription[1]}</size>";
        string[] src = $"{thin}<b>{{0}}</b></cspace>: {{1}}".MapWithFormat(
            new[]
            {
                res.ThreeTypedGeniusName,
                res.ThreeTypedGeniusTypesDescription
            });
        string typesDesc = res.CreateDetailList(src);
        return $"{lh}{desc1}{br}{typesDesc}{br}{desc2}{br}";
    }

    /// <summary>
    /// 論理思考タイプにおける、ページの文言を取得します。
    /// </summary>
    /// <param name="res">リソース。</param>
    /// <param name="type">論理思考タイプ。</param>
    /// <returns>ページの文言。</returns>
    public static string CreateBrainPage(
        this FallbackResources res, int type)
    {
        if (res == null)
        {
            return string.Empty;
        }
        string copy =
            string.Format(
                res.TemplateYourTypeIs, res.BrainTypeHeading[type]);
        return res.CreateByTemplate(
            res.BrainHeading,
            res.BrainDescription,
            $"{copy} {res.BrainTypeCopy[type]}",
            res.BrainTypeDetails[type],
            1.5f);
    }

    /// <summary>今後の解説拡充予告のメッセージを取得します。</summary>
    /// <returns>今後の解説拡充予告のメッセージ。</returns>
    public static string CreateComingSoon()
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return res == null ? string.Empty :
            $"{RIGHT}<size=23>▶{res.ComingSoon}◀</size>";
    }

    /// <summary>
    /// 対話思考タイプにおける、ページの文言を取得します。
    /// </summary>
    /// <param name="res">リソース。</param>
    /// <param name="type">対話思考タイプ。</param>
    /// <returns>ページの文言。</returns>
    public static string CreateCommunicationPage(
        this FallbackResources res, int type)
    {
        if (res == null)
        {
            return string.Empty;
        }
        string copy =
            string.Format(
                res.TemplateYourTypeIs, res.CommunicationTypeHeading[type]);
        return res.CreateByTemplate(
            res.CommunicationHeading,
            res.CommunicationDescription,
            $"{copy} {res.CommunicationTypeCopy[type]}",
            res.CommunicationTypeDetails[type],
            1.5f);
    }

    /// <summary>素質ページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="genius">素質タイプ。</param>
    /// <returns>素質ページの文言。</returns>
    public static string CreateDetailedGeniusPage(
        this FallbackResources res, int genius)
    {
        if (res == null)
        {
            return string.Empty;
        }
        string copy =
            string.Format(
                res.TemplateYourTypeIs, res.DetailedGeniusTypeName[genius]);
        return res.CreateByTemplate(
            res.DetailedGeniusHeading,
            res.DetailedGeniusDescription,
            $"{res.DetailedGeniusTypeSummary[genius]}: {copy}",
            res.DetailedGeniusTypeDetails[genius]);
    }

    /// <summary>素質毎に対する攻略法ページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="genius">素質タイプ。</param>
    /// <returns>素質毎に対する攻略法ページの文言。</returns>
    public static string CreateDetailedGeniusStrategyPage(
        this FallbackResources res, int genius)
    {
        return res == null
            ? string.Empty
            : res.CreateByTemplate(
                res.DetailedGeniusHeading,
                res.DetailedGeniusDescription,
                string.Format(
                    res.TemplateStrategy,
                    res.DetailedGeniusTypeName[genius]),
                res.DetailedGeniusTypeStrategy[genius]);
    }

    /// <summary>素質毎の弱点ページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="genius">素質タイプ。</param>
    /// <returns>素質毎の弱点ページの文言。</returns>
    public static string CreateDetailedGeniusWeaknessPage(
        this FallbackResources res, int genius)
    {
        return res == null
            ? string.Empty
            : res.CreateByTemplate(
                res.DetailedGeniusHeading,
                res.DetailedGeniusDescription,
                string.Format(
                    res.TemplateWeakness,
                    res.DetailedGeniusTypeName[genius]),
                res.DetailedGeniusTypeWeakness[genius]);
    }

    /// <summary>性格の大分類のページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="genius">大まかな性格タイプ。</param>
    /// <returns>性格の大分類のページの文言。</returns>
    public static string CreateGeniusPage(
        this FallbackResources res, int genius)
    {
        return res == null
            ? string.Empty
            : res.CreateByTemplate(
                res.GeniusHeading,
                res.GeniusDescription,
                string.Format(
                    res.TemplateYourTypeIs, res.GeniusTypesName[genius]),
                res.GeniusTypesDetails[genius]);
    }

    /// <summary>
    /// 性格の大分類に対する攻略法のページの文言を取得します。
    /// </summary>
    /// <param name="res">リソース。</param>
    /// <param name="genius">大まかな性格タイプ。</param>
    /// <returns>性格の大分類に対する攻略法のページの文言。</returns>
    public static string CreateGeniusStrategyPage(
        this FallbackResources res, int genius)
    {
        return res == null
            ? string.Empty
            : res.CreateByTemplate(
                res.GeniusHeading,
                res.GeniusDescription,
                string.Format(
                    res.TemplateStrategy, res.GeniusTypesName[genius]),
                res.GeniusTypesStrategies[genius],
                0.9f);
    }

    /// <summary>
    /// マインドキューブが空である場合の、警告ページを取得します。
    /// </summary>
    /// <returns>警告ページ。</returns>
    public static string[] CreateInvalidCubePage()
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return
            new[]
            {
                res == null ? string.Empty :
                    $"{CENTER}{res.WarnOnInsertTheEmptyMindCube}"
            };
    }

    /// <summary>人生観ページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="genius">人生観タイプ。</param>
    /// <returns>人生観ページの文言。</returns>
    public static string CreateLifeBasePage(
        this FallbackResources res, int lifebase)
    {
        if (res == null)
        {
            return string.Empty;
        }
        string copyHeading =
            string.Format(
                res.TemplateYourType, res.LifeBaseHeading.ToLower());
        return
            res.CreateByTemplate(
                res.LifeBaseHeading,
                res.LifeBaseDescription,
                $"{copyHeading}: {res.LifeBaseTypesName[lifebase]}",
                res.LifeBaseTypesDetail[lifebase],
                1.7f);
    }

    /// <summary>
    /// リスク管理思考タイプにおける、ページの文言を取得します。
    /// </summary>
    /// <param name="res">リソース。</param>
    /// <param name="type">リスク管理思考タイプ。</param>
    /// <returns>ページの文言。</returns>
    public static string CreateManagementPage(
        this FallbackResources res, int type)
    {
        if (res == null)
        {
            return string.Empty;
        }
        string copy =
            string.Format(
                res.TemplateYourTypeIs, res.ManagementTypeHeading[type]);
        return res.CreateByTemplate(
            res.ManagementHeading,
            res.ManagementDescription,
            $"{copy} {res.ManagementTypeCopy[type]}",
            res.ManagementTypeDetails[type],
            1.4f);
    }

    /// <summary>潜在能力ページの文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="potentialA">潜在能力 A。</param>
    /// <param name="potentialB">潜在能力 B。</param>
    /// <returns>潜在能力ページの文言。</returns>
    public static string CreatePotentialPage(
        this FallbackResources res, int potentialA, int potentialB)
    {
        if (res == null)
        {
            return string.Empty;
        }
        string copyHeading =
            string.Format(
                res.TemplateYourType, res.PotentialHeading.ToLower());
        return
            res.CreateByTemplate(
                res.PotentialHeading,
                res.PotentialDescription,
                copyHeading,
                res.BuiltPotentialDetails[potentialA][potentialB],
                1.3f);
    }

    /// <summary>
    /// 簡易ビューアーのページの文言を取得します。
    /// </summary>
    /// <param name="vars">マインドキューブの変数。</param>
    /// <returns>簡易ビューアーのページの文言。</returns>
    public static string CreateParametersPage(this MindCubeVariables vars)
    {
        // TODO: このメソッドはどこからも参照していないが、値の取得の参考用に当面残しておく。
        string[] dgRes = RES.DetailedGenius();
        string[] lbRes = RES.Lifebase();
        string[] ptRes = RES.Potential();
        byte[] dt = MasterData.DetailsMap()[vars.Inner];
        string io = $"Inner: {dgRes[vars.Inner]} <pos=50%>Outer: {dgRes[vars.Outer]}";
        string workstyle = $"Workstyle: {dgRes[vars.WorkStyle]} <pos=50%>Cycle: {vars.Cycle}";
        string lifebase = $"Lifebase: {lbRes[vars.LifeBase]}";
        string pb = $"Potential: {ptRes[vars.PotentialA]} - {ptRes[vars.PotentialB]} <pos=50%>Brain: {RES.Brain()[dt[(int)TDI.Brain]]}";
        string cm = $"Communication: {RES.Communication()[dt[(int)TDI.Communication]]} <pos=50%>Management: {RES.Management()[dt[(int)TDI.Management]]}";
        string genius = $"<color=#a0a0a0>Genius: {RES.GeneralGenius()[dt[(int)TDI.Genius]]}</color>";
        string motivation = $"Motivation: {RES.Motivation()[dt[(int)TDI.Motivation]]}";
        string pr = $"Position: {RES.Position()[dt[(int)TDI.Position]]} <pos=50%>Response: {RES.Response()[dt[(int)TDI.Response]]}";
        return $"{io}\n{workstyle}\n{lifebase}\n{pb}\n{cm}\n{genius}\n{motivation}\n{pr}";
    }

    /// <summary>
    /// 応対思考タイプにおける、ページの文言を取得します。
    /// </summary>
    /// <param name="res">リソース。</param>
    /// <param name="type">応対思考タイプ。</param>
    /// <returns>ページの文言。</returns>
    public static string CreateResponsePage(
        this FallbackResources res, int type)
    {
        if (res == null)
        {
            return string.Empty;
        }
        string copy =
            string.Format(
                res.TemplateYourTypeIs, res.ResponseTypeHeading[type]);
        return res.CreateByTemplate(
            res.ResponseHeading,
            res.ResponseDescription,
            $"{copy} {res.ResponseTypeCopy[type]}",
            res.ResponseTypeDetails[type],
            1.3f);
    }

    /// <summary>
    /// テンプレートに文言を埋め込んで、ページの文言を取得します。
    /// </summary>
    /// <param name="res">リソース。</param>
    /// <param name="heading">見出し。</param>
    /// <param name="description">説明。</param>
    /// <param name="copy">コピーライト。</param>
    /// <param name="details">詳細。</param>
    /// <param name="mulSizeLine">行の高さの倍率。</param>
    /// <returns>ページの文言。</returns>
    private static string CreateByTemplate(
        this FallbackResources res,
        string heading,
        string description,
        string copy,
        string[] details,
        float mulSizeLine = 1f)
    {
        int sizeLine = (int)(res.SizeLine * mulSizeLine);
        int catchHeight = (int)(sizeLine * 1.5f);
        string lh = $"<line-height={sizeLine}%>";
        string br = $"</line-height>\n<line-height={sizeLine / 3}%>\n</line-height>{lh}";
        string head = $"<cspace=-0.05em><smallcaps>{heading}</smallcaps></cspace>";
        string desc = $"{JUSTIFY}<size={res.SizeDescription}>{head}> {description}</size>";
        string cp = $"{CENTER}<size={res.SizeHeading}><line-height={catchHeight}%>{copy}</line-height></size>";
        return $"{lh}{desc}{br}{cp}{br}{res.CreateDetailList(details)}";
    }

    /// <summary>リストを連結し、文言を取得します。</summary>
    /// <param name="res">リソース。</param>
    /// <param name="list">リスト。</param>
    /// <returns>文言。</returns>
    private static string CreateDetailList(
        this FallbackResources res, string[] list)
    {
        if (list == null || list.Length == 0)
        {
            return string.Empty;
        }
        const string MARK = "◆";
        const string INDENT = "<indent=4%>";
        string body = string.Join($"</indent>\n{MARK}{INDENT}", list);
        return $"{JUSTIFY}<size={res.SizeDetails}>{MARK}{INDENT}{body}</indent></size>";
    }
}
