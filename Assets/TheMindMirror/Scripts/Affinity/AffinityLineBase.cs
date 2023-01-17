
using UdonSharp;
using UnityEngine;

/// <summary>相性ラインのベース。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class AffinityLineBase : UdonSharpBehaviour
{
#pragma warning disable IDE0044
#pragma warning disable IDE0051
    /// <summary>相性ラインの発射口。</summary>
    [SerializeField]
    private Transform muzzle;

    /// <summary>相性ライン。</summary>
    [SerializeField]
    private AffinityLine line;
#pragma warning restore IDE0044
#pragma warning restore IDE0051
}
