using UdonSharp;
using UnityEngine;

/// <summary>テキスト リソース群へのアクセサー。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class ResourcesManager : Subject
{
#pragma warning disable IDE0044
    /// <summary>選択可能なリソース群。</summary>
    [SerializeField]
    private FallbackResources[] availableResources;
#pragma warning restore IDE0044

    /// <summary>現在選択中のリソース群。</summary>
    private FallbackResources resources;

    /// <summary>選択可能なリソース群を取得します。</summary>
    public FallbackResources[] AvailableResources => availableResources;

    /// <summary>既定のリソース群を取得、または設定します。</summary>
    /// <remarks>設定した際にオブザーバー各位に通知します。</remarks>
    public FallbackResources Resources
    {
        get => resources;
        set
        {
            if (value == null)
            {
                return;
            }
            resources = value;
            SendCustomEventDelayedFrames(nameof(Notify), 1);
        }
    }

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
