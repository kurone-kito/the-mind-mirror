using UdonSharp;
using UnityEngine;

/// <summary>テキスト リソース群へのアクセサー。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class ResourcesManager : UdonSharpBehaviour
{
#pragma warning disable IDE0044
    /// <summary>既定のリソース群。</summary>
    [SerializeField]
    private FallbackResources defaultResources;
#pragma warning restore IDE0044

    /// <summary>既定のリソース群。</summary>
    public FallbackResources Resources => defaultResources;

    /// <summary>
    /// テキスト リソース群へのアクセサーを取得します。
    /// </summary>
    /// <returns>テキスト リソース群へのアクセサー。</returns>
    public static ResourcesManager GetInstance()
    {
        GameObject obj = GameObject.Find(nameof(ResourcesManager));
#pragma warning disable IDE0031
        return obj == null ? null : obj.GetComponent<ResourcesManager>();
#pragma warning restore IDE0031
    }
}
