using UdonSharp;
using UnityEngine;

/// <summary>マルチ リソース対応ラベル一覧。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class Labels : UdonSharpBehaviour
{
#pragma warning disable IDE0044
#pragma warning disable IDE0052
    /// <summary>マルチ リソース対応ラベル一覧。</summary>
    [SerializeField]
    private GameObject[] labels = new GameObject[0];
#pragma warning restore IDE0044
#pragma warning restore IDE0052

    /// <summary>マルチ リソース対応ラベルを取得します。</summary>
    public GameObject this[int index] => labels[index];

    /// <summary>マルチ リソース対応ラベルの数を取得します。</summary>
    public int Length => labels.Length;
}
