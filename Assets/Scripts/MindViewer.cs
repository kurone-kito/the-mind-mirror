using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MindViewer : MindStack
{
#pragma warning disable IDE0044
#pragma warning disable IDE0051
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
#pragma warning disable IDE0051
}
