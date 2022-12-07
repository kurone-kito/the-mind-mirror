using UdonSharp;

/// <summary>日本語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class JaResources : FallbackResources
{
    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Japanese;
}
