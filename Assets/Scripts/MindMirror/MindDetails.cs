using TMPro;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

using RES = Parameters;
using TDI = TypeDetailIndex;

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

    /// <summary>
    /// 簡易ビューアのページにおける、見出しメッセージ。
    /// </summary>
    private const string INFO_PARAMS_HEADING =
        @"<align=""center""><size=540>(暫定版)パラメーター情報
<align=""center""><size=480>この表示値の解説は、今後のアップデートで追加いたします。
<align=""left""><size=330>";


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
    /// 簡易ビューアーのページの文言を取得します。
    /// </summary>
    /// <returns>簡易ビューアーのページの文言。</returns>
    private string GetParametersPage()
    {
        MindCubeVariables vars = globalStackManager.GetMindCubeVariables();
        string[] dgRes = RES.DetailedGenius();
        string[] lbRes = RES.Lifebase();
        string[] ptRes = RES.Potential();
        byte[] dt = MasterData.DetailsMap()[vars.Inner];
        string io = $"Inner: {dgRes[vars.Inner]} <pos=50%>Outer: {dgRes[vars.Outer]}";
        string workstyle = $"Workstyle: {dgRes[vars.WorkStyle]} <pos=50%>Cycle: {vars.Cycle}";
        string lifebase = $"Lifebase: {lbRes[vars.LifeBase]}";
        string pb = $"Potential: {ptRes[vars.PotentialA]} - {ptRes[vars.PotentialB]} <pos=50%>Brain: {RES.Brain()[dt[(int)TDI.Brain]]}";
        string cm = $"Communication: {RES.Communication()[dt[(int)TDI.Communication]]} <pos=50%>Management: {RES.Management()[dt[(int)TDI.Management]]}";
        string genius = $"Genius: {RES.GeneralGenius()[dt[(int)TDI.Genius]]}";
        string motivation = $"Motivation: {RES.Motivation()[dt[(int)TDI.Motivation]]}";
        string pr = $"Position: {RES.Position()[dt[(int)TDI.Position]]} <pos=50%>Response: {RES.Response()[dt[(int)TDI.Response]]}";
        return $"{INFO_PARAMS_HEADING}\n{io}\n{workstyle}\n{lifebase}\n{pb}\n{cm}\n{genius}\n{motivation}\n{pr}";
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
            contents = new[] { WARN_INSERTED_THE_EMPTY_MIND_CUBE };
            UpdateContents();
            return;
        }
        contents = new[] { GetParametersPage() };
        nameLabel.text = cube.CubeName;
        UpdateContents();
    }
}
