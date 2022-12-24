using UdonSharp;
using UnityEngine;

/// <summary>表示テスト用の結果情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class ResultPreviewer : ResultPreviewerBase
{
#pragma warning disable IDE0044
    /// <summary>本文ラベル。</summary>
    [SerializeField]
    private GameObject collapsed;

    /// <summary>ページネーションのラベル。</summary>
    [SerializeField]
    private GameObject expanded;
#pragma warning restore IDE0044

    /// <summary>ページ内容を更新します。</summary>
    public void UpdatePages()
    {
        Contents =
            new[]
            {
                PageGenerator.CreateGeniusPage((int)TypeGenius.Authority),
                PageGenerator.CreateGeniusPage((int)TypeGenius.Economically),
                PageGenerator.CreateGeniusPage((int)TypeGenius.Humanely),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.A000),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.E001),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.H012),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.A024),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.H025),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.A100),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.H108),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.E125),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.E555),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.H789),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.A888),
                PageGenerator.CreateDetailedGeniusPage((int)TypeDetailedGenius.E919),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.A000),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.E001),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.H012),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.A024),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.H025),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.A100),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.H108),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.E125),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.E555),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.H789),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.A888),
                PageGenerator.CreateDetailedGeniusWeaknessPage((int)TypeDetailedGenius.E919),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.A000),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.E001),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.H012),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.A024),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.H025),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.A100),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.H108),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.E125),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.E555),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.H789),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.A888),
                PageGenerator.CreateDetailedGeniusStrategyPage((int)TypeDetailedGenius.E919),
            };
    }

    /// <summary>描画状態を更新します。</summary>
    protected override void UpdateContents()
    {
        UpdatePages();
        base.UpdateContents();
    }

#pragma warning disable IDE0051
    /// <summary>初期化時に呼び出す、コールバック。</summary>
    private void Start()
    {
        collapsed.SetActive(true);
        expanded.SetActive(false);
        SendCustomEventDelayedFrames(nameof(UpdatePages), 1);
    }
#pragma warning restore IDE0051
}
