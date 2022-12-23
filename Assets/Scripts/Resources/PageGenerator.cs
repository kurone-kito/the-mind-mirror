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

    /// <summary>今後の解説拡充予告のメッセージを取得します。</summary>
    /// <returns>今後の解説拡充予告のメッセージ。</returns>
    public static string CreateComingSoon()
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return $"{RIGHT}<size=230>▶{res.ComingSoon}◀</size>";
    }

    /// <summary>素質ページの文言を取得します。</summary>
    /// <param name="genius">素質タイプ。</param>
    /// <returns>素質ページの文言。</returns>
    public static string CreateDetailedGeniusPage(int genius)
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        if (res == null)
        {
            return string.Empty;
        }
        string copy =
            string.Format(
                res.TemplateYourTypeIs, res.DetailedGeniusTypeName[genius]);
        return CreateByTemplate(
            res.DetailedGeniusHeading,
            res.DetailedGeniusDescription,
            $"{res.DetailedGeniusTypeSummary[genius]}: {copy}",
            res.DetailedGeniusTypeDetails[genius]);
    }

    /// <summary>性格の大分類のページの文言を取得します。</summary>
    /// <param name="genius">大まかな性格タイプ。</param>
    /// <returns>性格の大分類のページの文言。</returns>
    public static string CreateGeniusPage(int genius)
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return CreateByTemplate(
            res.GeniusHeading,
            res.GeniusDescription,
            string.Format(
                res.TemplateYourTypeIs, res.GeniusTypesName[genius]),
            res.GeniusTypesDetails[genius]
        );
    }

    /// <summary>
    /// マインドキューブが空である場合の、警告ページを取得します。
    /// </summary>
    /// <returns>警告ページ。</returns>
    public static string[] CreateInvalidCubePage()
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        return new[] { $"{CENTER}{res.WarnOnInsertTheEmptyMindCube}" };
    }

    /// <summary>
    /// 簡易ビューアーのページの文言を取得します。
    /// </summary>
    /// <param name="vars">マインドキューブの変数。</param>
    /// <returns>簡易ビューアーのページの文言。</returns>
    public static string CreateParametersPage(MindCubeVariables vars)
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
    /// テンプレートに文言を埋め込んで、ページの文言を取得します。
    /// </summary>
    /// <param name="heading">見出し。</param>
    /// <param name="description">説明。</param>
    /// <param name="copy">コピーライト。</param>
    /// <param name="details">詳細。</param>
    /// <returns>ページの文言。</returns>
    private static string CreateByTemplate(
        string heading, string description, string copy, string[] details)
    {
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        string lh = $"<line-height={res.SizeLine}%>";
        string br = $"</line-height>\n<line-height={res.SizeLine / 3}%>\n</line-height>{lh}";
        string head = $"<cspace=-0.1em><smallcaps>{heading}</smallcaps></cspace>";
        string desc = $"{JUSTIFY}<size={res.SizeDescription}>{head}> {description}</size>";
        string cp = $"{CENTER}<size={res.SizeHeading}><line-height={(int)(res.SizeLine * 1.5f)}%>{copy}</line-height></size>";
        return $"{lh}{desc}{br}{cp}{br}{CreateDetailList(details)}";
    }

    /// <summary>リストを連結し、文言を取得します。</summary>
    /// <param name="list">リスト。</param>
    /// <returns>文言。</returns>
    private static string CreateDetailList(string[] list)
    {
        if (list == null || list.Length == 0)
        {
            return string.Empty;
        }
        const string MARK = "▶";
        const string INDENT = "<indent=4%>";
        FallbackResources res = ResourcesManager.GetInstance().Resources;
        string body = string.Join($"</indent>\n{MARK}{INDENT}", list);
        return $"{JUSTIFY}<size={res.SizeDetails}>{MARK}{INDENT}{body}</indent></size>";
    }
}
