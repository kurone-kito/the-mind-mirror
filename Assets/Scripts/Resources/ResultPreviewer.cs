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
