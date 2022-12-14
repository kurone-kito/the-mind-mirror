using UdonSharp;

/// <summary>日本語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class JaResources : FallbackResources
{
    /// <summary>性格の大分類の見出し。</summary>
    public override string GeniusHeading => "性格の大分類";

    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Japanese;
}
