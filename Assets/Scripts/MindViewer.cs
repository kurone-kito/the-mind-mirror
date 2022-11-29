using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

using RES = Parameters;
using TDI = TypeDetailIndex;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MindViewer : MindStack
{
    /// <summary>名無しの場合に表示する、代替文字列。</summary>
    private const string ANONYMOUS = "Anonymous";

    /// <summary>無効の場合に表示する、代替文字列。</summary>
    private const string NOT_APPLICABLE = "N/A";

#pragma warning disable IDE0044
    /// <summary>思考タイプ。</summary>
    [SerializeField]
    private Text brain;

    /// <summary>対話における思考タイプ。</summary>
    [SerializeField]
    private Text communication;

    /// <summary>補助的な素質の変化。</summary>
    [SerializeField]
    private Text cycle;

    /// <summary>表示名。</summary>
    [SerializeField]
    private Text displayName;

    /// <summary>大まか素質タイプ。</summary>
    [SerializeField]
    private Text genius;

    /// <summary>内面的な素質。</summary>
    [SerializeField]
    private Text inner;

    /// <summary>根底となる人生観。</summary>
    [SerializeField]
    private Text lifebase;

    /// <summary>リスク管理のタイプ。</summary>
    [SerializeField]
    private Text management;

    /// <summary>モチベーションが出やすい環境タイプ。</summary>
    [SerializeField]
    private Text motivation;

    /// <summary>外面的な素質。</summary>
    [SerializeField]
    private Text outer;

    /// <summary>素質を持つ、立ち位置タイプ。</summary>
    [SerializeField]
    private Text position;

    /// <summary>行動を起こす際の、潜在能力。</summary>
    [SerializeField]
    private Text potential;

    /// <summary>素質を持つ、立ち位置タイプ。</summary>
    [SerializeField]
    private Text response;

    /// <summary>緊急時・集中時の素質。</summary>
    [SerializeField]
    private Text workstyle;
#pragma warning restore IDE0044

    private void UpdateGeniusDetail()
    {
        if (MindCube.Variables.Inner >= 12)
        {
            brain.text = NOT_APPLICABLE;
            communication.text = NOT_APPLICABLE;
            genius.text = NOT_APPLICABLE;
            management.text = NOT_APPLICABLE;
            motivation.text = NOT_APPLICABLE;
            position.text = NOT_APPLICABLE;
            response.text = NOT_APPLICABLE;
            return;
        }
        byte[] dt = MasterData.DetailsMap()[MindCube.Variables.Inner];
        brain.text = RES.Brain()[dt[(int)TDI.Brain]];
        communication.text = RES.Communication()[dt[(int)TDI.Communication]];
        genius.text = RES.GeneralGenius()[dt[(int)TDI.Genius]];
        management.text = RES.Management()[dt[(int)TDI.Management]];
        motivation.text = RES.Motivation()[dt[(int)TDI.Motivation]];
        position.text = RES.Position()[dt[(int)TDI.Position]];
        response.text = RES.Response()[dt[(int)TDI.Response]];
    }

    /// <summary>性格情報の表示を更新します。</summary>
    private void UpdatePersonality()
    {
        MindCubeVariables vars = MindCube.Variables;
        string[] dgRes = RES.DetailedGenius();
        string[] lbRes = RES.Lifebase();
        string[] ptRes = RES.Potential();
        cycle.text = vars.Cycle.ToString();
        displayName.text =
            string.IsNullOrWhiteSpace(vars.CubeName) ? ANONYMOUS :
            vars.CubeName;
        if (Mathf.Max(vars.Inner, vars.Outer, vars.WorkStyle) < 12)
        {
            inner.text = dgRes[vars.Inner];
            outer.text = dgRes[vars.Outer];
            workstyle.text = dgRes[vars.WorkStyle];
        }
        else
        {
            inner.text = NOT_APPLICABLE;
            outer.text = NOT_APPLICABLE;
            workstyle.text = NOT_APPLICABLE;
        }
        if (Mathf.Max(vars.LifeBase, vars.PotentialA, vars.PotentialB) < 10)
        {
            lifebase.text = lbRes[vars.LifeBase];
            potential.text =
                $"{ptRes[vars.PotentialA]} - {ptRes[vars.PotentialB]}";
        }
        else
        {
            lifebase.text = NOT_APPLICABLE;
            potential.text = NOT_APPLICABLE;
        }
        cycle.text = vars.Cycle.ToString();
    }

    /// <summary>
    /// マインドキューブの有無が変化した際に呼び出す、コールバック。
    /// </summary>
    protected override void OnUpdateMindCube()
    {
        base.OnUpdateMindCube();
        if (MindCube == null || MindCube.Variables == null)
        {
            return;
        }
        UpdatePersonality();
        UpdateGeniusDetail();
    }
}
