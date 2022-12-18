using UdonSharp;

/// <summary>フォールバック言語用テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class FallbackResources : UdonSharpBehaviour
{
    /// <summary>性格の大分類の見出し。</summary>
    public virtual string GeniusHeading => "Major categories of personality";

    /// <summary>性格の大分類の説明。</summary>
    public virtual string GeniusDescription =>
        $"人の性格は大きく 3 つ、{GeniusTypes[(int)TypeGenius.Authority]}、{GeniusTypes[(int)TypeGenius.Economically]}、{GeniusTypes[(int)TypeGenius.Humanely]} に分類できます。";

    /// <summary>性格の大分類の種別ごとの見出し。</summary>
    public virtual string[] GeniusTypes =>
        new[] { "アート脳タイプ", "理系脳タイプ", "文系脳タイプ" };

    /// <summary>性格の大分類の種別ごとの説明。</summary>
    public virtual string[][] GeniusTypesDescriptions => new[]
    {
        new[]
        {
            "<b>己の権威のため</b>を根底のエゴとし、将来性を追求するタイプです。",
            $"{GeniusTypes[(int)TypeGenius.Authority]}は、<b>長話を聞けません</b>。重要な話でないと判断した途端、スマホをいじったり、居眠りしたりなど、<b>露骨に話を聞かなく</b>なります。",
            $"ブランドモノだから、と言う理由でブランドものを集める人は、概ね{GeniusTypes[(int)TypeGenius.Authority]}の傾向があります。",
            "漠然とした、具現化しにくい不安を持っている人が多く、またその不安を原動力に転嫁しやすい特性があります。",
        },
        new[]
        {
            "<b>己の富のため</b>を根底のエゴとし、効率性を追求するタイプです。",
            "スペック至上主義の傾向があり、ブランドものを軽視する傾向が強いです。ただし、ブランドも一種のスペックと考え、重視する人も稀にいます。",
            $"{GeniusTypes[(int)TypeGenius.Economically]}は、<b>長話を聞けません</b>。“<b>つまりこういうことだよね？</b>”と、脳内で<b>要点だけかいつまんで理解</b>しようとします。",
        },
        new[]
        {
            "<b>己の人格のため</b>を根底のエゴとし、社会性を追求するタイプです。",
            "多くのことに対し、人柄に重点を置きがちで、店とかで商品を選ぶ際、スペック関係ないのに、販売員の人柄で決めてしまったりする傾向があります。",
            $"{GeniusTypes[(int)TypeGenius.Humanely]}は、総じて長話をちゃんとニコニコ最初から最後まで聞ける傾向があります。ただし<b>頭に入っているかどうかは別の話</b>。",
            "話を端折ると“なんで？”となり、その後の話が理解できなくなりがちです。家族で映画とか見る時、勝手にシークバーいじって顰蹙買うことも。",
        },
    };

    /// <summary>各項目のタイプ見出しの前置詞および後置詞。</summary>
    public virtual string[] YourTypeIs => new[] { "あなたは", "です。" };

    /// <summary>言語種別。</summary>
    public virtual TypeLanguage Type => TypeLanguage.English;
}
