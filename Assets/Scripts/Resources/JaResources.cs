using UdonSharp;

/// <summary>日本語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class JaResources : FallbackResources
{
    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public override string ComingSoon =>
         "今後もっと解説を拡充していきます！";

    /// <summary>性格の大分類の説明。</summary>
    public override string GeniusDescription =>
        $"人の性格は大きく 3 つ、{GeniusTypes[(int)TypeGenius.Authority]}、{GeniusTypes[(int)TypeGenius.Economically]}、{GeniusTypes[(int)TypeGenius.Humanely]} に分類できます。";

    /// <summary>性格の大分類の見出し。</summary>
    public override string GeniusHeading => "性格の大分類";

    /// <summary>性格の大分類の種別ごとの見出し。</summary>
    public override string[] GeniusTypes => new[]
    {
        "アート脳タイプ",
        "理系脳タイプ",
        "文系脳タイプ",
    };

    /// <summary>性格の大分類の種別ごとの説明。</summary>
    public override string[][] GeniusTypesDescriptions =>
        new[]
        {
            new[]
            {
                "<b>己の権威のため</b>を根底のエゴとし、将来性を追求するタイプです。",
                $"{GeniusTypes[(int)TypeGenius.Authority]}は、<b>長話を聞けません</b>。重要な話でないと判断した途端、スマホをいじったり、居眠りしたりなど、<b>露骨に話を聞かなく</b>なります。",
                $"ブランドもので着飾りたい願望を持つ人は、概ね{GeniusTypes[(int)TypeGenius.Authority]}の傾向があります。",
                "漠然とした、具現化しにくい不安を持っている人が多く、またその不安を原動力に転嫁しやすい特性があります。",
            },
            new[]
            {
                "<b>己の富のため</b>を根底のエゴとし、効率性を追求するタイプです。",
                "スペック至上主義の傾向があり、ブランドものを軽視する傾向が強いです。ただし、ブランドも一種のスペックと考え、次点程度に重視する人もいます。",
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

    /// <summary>3 種類の素質の名前。</summary>
    public override string[] ThreeTypedGeniusName =>
        new[] { "本性", "装い", "集中" };

    /// <summary>3 種類の素質の各解説。</summary>
    public override string[] ThreeTypedGeniusTypesDescription =>
        new[]
        {
            "根底にある性格",
            "相手を信用しない時に出る性格",
            "集中時や緊急時に現れる性格"
        };

    /// <summary>
    /// 空のマインドキューブを挿入した際の、警告メッセージ。
    /// </summary>
    public override string WarnOnInsertTheEmptyMindCube =>
         @"診断するマインドキューブが<b>抜け殻</b>のようで、診断ができません。
お隣の部屋のマインドライターで魂の情報を書き込んでから、再度お試しください。";

    /// <summary>ページ番号のテンプレート。</summary>
    public override string TemplatePages => "{0}/{1} ページ";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public override string TemplateYourTypeIs => "あなたは<b>{0}</b>です！";

    /// <summary>説明サイズ。</summary>
    public override int SizeDescription => 240;

    /// <summary>詳細サイズ。</summary>
    public override int SizeDetails => 230;

    /// <summary>見出しサイズ。</summary>
    public override int SizeHeading => 500;

    /// <summary>説明サイズ。</summary>
    public override int SizeLine => 90;

    /// <summary>小見出しサイズ。</summary>
    public override int SizeSubHeading => 480;

    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Japanese;
}
