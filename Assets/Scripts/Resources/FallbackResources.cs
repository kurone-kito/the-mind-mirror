using UdonSharp;

/// <summary>フォールバック言語用テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class FallbackResources : UdonSharpBehaviour
{
    /// <summary>言語種別。</summary>
    public virtual TypeLanguage Type => TypeLanguage.English;
}
