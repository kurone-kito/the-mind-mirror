using UdonSharp;

/// <summary>日本語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class JaResources : FallbackResources
{
    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public override string ComingSoon =>
         "今後もっと解説を拡充していきます！";

    /// <summary>素質の解説。</summary>
    public override string DetailedGeniusDescription =>
        "より詳細な、天性の性格。これは 12 種類に分類します。";

    /// <summary>素質の見出し。</summary>
    public override string DetailedGeniusHeading => "素質";


    /// <summary>各素質の解説。</summary>
    public override string[][] DetailedGeniusTypeDetails =>
        new[]
        {
            new[]
            {
                "(既存の言語で言い表せない)超言語的哲学……ぶっ飛んだ世界観を持っています。霊感と表現している人もいます。",
                "ただし行動力はあまり高くなく、頭の中で留めている人が多いです。",
                $"浮遊霊のように、無計画で旅に出て、連絡が付かなくなることも、{DetailedGeniusTypeName[(int)TypeDetailedGenius.A000]}あるあるです。",
            },
            new[]
            {
                "他人の思想に染まらず、変人のように振舞うのが大好きです。",
                "全てにおいて、没個性的な物事を嫌い、マイペースに活動することを好みます。",
                "“緻密に計算されたバカ”・“実は天才なバカ”役を演じるには、最強の適役と言えるでしょう。",
            },
            new[]
            {
                "大人になっても青春時代のような印象を持つ、青年気質なタイプです。",
                "話し合いが好きな傾向がありますが、これは一長一短で中身の薄い長話に陥りがちです。",
                "人前に出たがりな反面、黒子的な振る舞いで全体をサポートするのも得意です。",
            },
            new[]
            {
                "やると決めたことは、最後までやり遂げようとする努力家タイプですが、細かい戦略を練るのは不得手です。",
                "普段温和ですが、せっかちで最強の行動力を持つタイプです。",
                $"{GeniusTypesName[(int)TypeGenius.Authority]}は全般的に、不安を行動の原動力に転換できる才能を持っていますが、{DetailedGeniusTypeName[(int)TypeDetailedGenius.A024]}はその能力が特に顕著です。",
                "今初めて知ったことを、まるで 10 年前から知っていたかのような口ぶりで語れるような、暗記力と演技力を持っている人が多いです。",
            },
            new[]
            {
                "人類皆兄弟のような意識を持ち、誰とも等しく平等に仲良くできる素質を持ちます。",
                "一方で“等しく仲良し”のため、家族であっても必ず一線をひきます。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H025]}は多くの人のコネを持てることから、必然的に事情通になる傾向が多いです。",
            },
            new[]
            {
                "苦手なふりしておきながら、ちゃっかり準備しておいて驚かして目立つことを好みます。",
                "自力でやろうとなんでも抱えてしまい、結果としてパフォーマンスが落ちる傾向があります。",
            },
            new[]
            {
                "赤子のように、素直で正直な性格を持つことが多いです。",
                "非常に人見知りが激しく、知らない人ばかりのところに放り込まれると、借りて来た猫のように大人しくなる人が多いです。",
            },
            new[]
            {
                "人生を長く見据えて、大きくロマンチストな夢を持っている人が多いです。",
                "そしてその夢に対し、短期的にはどこまでもストイックになれる素質を持っています。",
            },
            new[]
            {
                "ベテラン社員のような、万能感と親分肌のような空気感を持つ人が多いです。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.E555]}は、未経験のことであっても、人一倍早く慣れることができます。",
                "一方で、その道の達人になるには、他タイプの数倍努力が必要となります。すなわち、エキスパートというよりジェネラリスト向けの素質といえます。"
            },
            new[]
            {
                "社長・会長のような、控えめながらも堂々とした芯を持つ人が多いです。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H789]}は、部分的に{GeniusTypesName[(int)TypeGenius.Authority]}のような性質を重ね持ち、相手の権威を量り、本物を見抜く眼力を備えています。",
                "また自分の権威をより盤石にすべく、自分磨きを欠かしません。",
                "縁の下の力持ちとして活躍するのが得意な反面、ここぞというタイミングで人前に出て、美味しいところを攫っていきたい欲求があります。",
            },
            new[]
            {
                "少年少女のような、至る方向に興味を持つチャレンジ気質を持ちます。",
                "とにかく打たれ強く、叩かれたことにすら気づかない人が多いです。",
            },
            new[]
            {
                "一瞬の集中力は凄まじいですが、それ以外の時間は常に怠けている気質を持ちます。やる気スイッチのオンオフが最もわかりやすいタイプです。",
                "欲しいものは何がなんでも手に入れるという、強い気質を持っています。",
                "駆け引きが得意で、営業職向けの素質があります。",
            },
        };

    /// <summary>素質の見出し。</summary>
    public override string[] DetailedGeniusTypeName =>
        new[]
        {
            "敏感タイプ",
            "独自タイプ",
            "先端タイプ",
            "努力タイプ",
            "配慮タイプ",
            "完璧タイプ",
            "自然タイプ",
            "夢想タイプ",
            "悠然タイプ",
            "実績タイプ",
            "挑戦タイプ",
            "実益タイプ",
        };

    /// <summary>素質のキャッチコピー。</summary>
    public override string[] DetailedGeniusTypeSummary =>
        new[]
        {
            "鋭い直感と閃きを武器に、無目的な放浪が好きなタイプ",
            "奇人変人は褒め言葉！周りに流されず我流のアイデアで勝負",
            "新しいモノ大好き！日々新鮮さを求めるヒトバシラー気質",
            "せっかちで、最強の行動力を持つ",
            "他人大好き、事情通な人格者",
            "生真面目で頑固一徹！弱音を吐かなかい一流ビジネスマン気質",
            "人見知りだけど、慣れれば裏表のないド正直もの",
            "夢と自己管理で敵う者なし！長期戦で目標へ一直線",
            "バランス型能力と面倒見が良い、勇者的ポジション",
            "実績経験を重んじて、役割分担が上手い影の実力者のようなタイプ",
            "天真爛漫で興味旺盛！ダメでも気にせず挑戦し続けるタイプ",
            "先手必勝の短期決戦型！駆け引き上手なタイプ",
        };

    /// <summary>性格の大分類の説明。</summary>
    public override string GeniusDescription =>
        $"人の性格は大きく 3 つ、{GeniusTypesName[(int)TypeGenius.Authority]}、{GeniusTypesName[(int)TypeGenius.Economically]}、{GeniusTypesName[(int)TypeGenius.Humanely]} に分類できます。";

    /// <summary>性格の大分類の見出し。</summary>
    public override string GeniusHeading => "性格の大分類";

    /// <summary>性格の大分類の種別ごとの見出し。</summary>
    public override string[] GeniusTypesName =>
        new[] { "アート脳タイプ", "理系脳タイプ", "文系脳タイプ" };

    /// <summary>性格の大分類の種別ごとの説明。</summary>
    public override string[][] GeniusTypesDetails =>
        new[]
        {
            new[]
            {
                "<b>己の権威のため</b>を根底のエゴとし、将来性を追求するタイプです。",
                $"{GeniusTypesName[(int)TypeGenius.Authority]}は、<b>長話を聞けません</b>。重要な話でないと判断した途端、スマホをいじったり、居眠りしたりなど、<b>露骨に話を聞かなく</b>なります。",
                $"ブランドもので着飾りたい願望を持つ人は、概ね{GeniusTypesName[(int)TypeGenius.Authority]}の傾向があります。",
                "漠然とした、具現化しにくい不安を持っている人が多く、またその不安を原動力に転嫁しやすい特性があります。",
            },
            new[]
            {
                "<b>己の富のため</b>を根底のエゴとし、効率性を追求するタイプです。",
                "スペック至上主義の傾向があり、ブランドものを軽視する傾向が強いです。ただし、ブランドも一種のスペックと考え、次点程度に重視する人もいます。",
                $"{GeniusTypesName[(int)TypeGenius.Economically]}は、<b>長話を聞けません</b>。“<b>つまりこういうことだよね？</b>”と、脳内で<b>要点だけかいつまんで理解</b>しようとします。",
            },
            new[]
            {
                "<b>己の人格のため</b>を根底のエゴとし、社会性を追求するタイプです。",
                "多くのことに対し、人柄に重点を置きがちで、店とかで商品を選ぶ際、スペック関係ないのに、販売員の人柄で決めてしまったりする傾向があります。",
                $"{GeniusTypesName[(int)TypeGenius.Humanely]}は、総じて長話をちゃんとニコニコ最初から最後まで聞ける傾向があります。ただし<b>頭に入っているかどうかは別の話</b>。",
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
    public override int SizeHeading => 400;

    /// <summary>説明サイズ。</summary>
    public override int SizeLine => 85;

    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Japanese;
}
