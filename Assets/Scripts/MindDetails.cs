using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindDetails : UdonSharpBehaviour
{
#pragma warning disable IDE0044
#pragma warning disable IDE0051
    /// <summary>フォーム本体。</summary>
    [SerializeField]
    private GameObject body;
#pragma warning restore IDE0044
#pragma warning restore IDE0051
}
