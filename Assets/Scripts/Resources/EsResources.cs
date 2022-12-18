using UdonSharp;

/// <summary>スペイン語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class EsResources : FallbackResources
{
    /// <summary>性格の大分類の見出し。</summary>
    public override string GeniusHeading => "Principales categorías de personalidad";

    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Spanish;
}
