using UdonSharp;

/// <summary>日本語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class JaResources : FallbackResources
{
    /// <summary>論理思考タイプの見出しメッセージ。</summary>
    public override string BrainDescription =>
        $"人によって{BrainTypeHeading[(int)TypeBrain.Left]}か{BrainTypeHeading[(int)TypeBrain.Right]}かに分かれます。";

    /// <summary>論理思考タイプの見出しメッセージ。</summary>
    public override string BrainHeading => "論理思考タイプ";

    /// <summary>論理思考タイプのタイプ別コピー。</summary>
    public override string[] BrainTypeCopy =>
        new[]
        {
            "<b>論理的思考</b>が優れています。",
            "<b>直感的思考</b>が優れています。",
        };

    /// <summary>論理思考タイプのタイプ別解説。</summary>
    public override string[][] BrainTypeDetails =>
        new[]
        {
            new[]
            {
                "<b>数値・データに基づいて考えることが得意</b>である一方、<b>漫然な状況では混乱</b>しがちな傾向があります。",
                "数値的なエビデンスに固執してしまい、<b>直感的に動くことは苦手</b>です。",
            },
            new[]
            {
                "ブレストなど、<b>想像力を使うことが得意</b>である一方、<b>エビデンスを軽視し、直感優先</b>で動いてしまう傾向があります。",
                "<b>忙しい状況では、思考停止に</b>陥りがちです。",
            },
        };

    /// <summary>論理思考タイプのタイプ別名称。</summary>
    public override string[] BrainTypeHeading =>
        new[] { "左脳思考", "右脳思考" };

    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public override string ComingSoon =>
         "今後もっと解説を拡充していきます！";

    /// <summary>対話思考タイプの見出しメッセージ。</summary>
    public override string CommunicationDescription =>
        $"人によって{CommunicationTypeHeading[(int)TypeCommunication.Fix]}か{CommunicationTypeHeading[(int)TypeCommunication.Flex]}かに分かれます。";

    /// <summary>対話思考タイプの見出しメッセージ。</summary>
    public override string CommunicationHeading => "対話における思考方法";

    /// <summary>対話思考タイプのタイプ別コピー。</summary>
    public override string[] CommunicationTypeCopy =>
        new[]
        {
            "<b>結論ありき</b>で対話を進めるタイプです。",
            "<b>流動的</b>に着地点を決めて行くタイプです。",
        };

    /// <summary>対話思考タイプのタイプ別解説。</summary>
    public override string[][] CommunicationTypeDetails =>
        new[]
        {
            new[]
            {
                "理詰めで自分の主張を通していく傾向もあります。",
                "時間や場所など、はっきり<b>明確になると安心</b>する反面、曖昧だと不安になる人が多いです。",
            },
            new[]
            {
                "感情論で自分の主張を通していく傾向もあります。",
                "時間や場所など、曖昧でもどうにかなる反面、<b>明確にすると窮屈</b>に感じる人が多いです。",
            },
        };

    /// <summary>対話思考タイプのタイプ別名称。</summary>
    public override string[] CommunicationTypeHeading =>
        new[] { "明確化指向", "柔軟指向" };

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

    /// <summary>各素質に対する、攻略法の解説。</summary>
    public override string[][] DetailedGeniusTypeStrategy =>
        new[]
        {
            new[]
            {
                "ありとあらゆる拘束・束縛・ルールを嫌います。",
                "依頼などに対し“わかった(わかってない)”と言いがちです。確認をとってあげると後々のトラブル回避に繋がります。",
                "集団で何かをする場合、独創性を問われるポジションに置くと良いでしょう。",
            },
            new[]
            {
                "初見はとっつきにくいと思いますが、仲良くなると優しくしてくれます。",
                $"変人、変わっている、などの言葉は一般的に悪口となりますが、{DetailedGeniusTypeName[(int)TypeDetailedGenius.E001]}に限り例外で、褒め言葉となります。",
                "逆に没個性的なワード、常識人であることを褒める行為などは悪口となり得ますので注意です。",
                "集団で何かをやる場合、独創性を問われるポジションに就かせると最高のパフォーマンスを発揮します。",
            },
            new[]
            {
                $"“誰も知らない”・“最新情報です”は、{DetailedGeniusTypeName[(int)TypeDetailedGenius.H012]}を振り向かせるパワーワードです。",
                "逆に枯れている、実績があるなどと安定性に訴えかける触れ込みは、彼らの興味を削ぐ結果となるでしょう。",
            },
            new[]
            {
                $"人を怒らせるのは一般的に得策ではありませんが、{DetailedGeniusTypeName[(int)TypeDetailedGenius.A024]}は特にタブーです。普段融和な雰囲気ですが、めちゃくちゃ怖い目を見ることになるでしょう。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.A024]}は対人調整役やディレクターが適役です。一方で企画の責を与えると、短命商品を連発してしまいます。不安からコロコロ商品を変えてしまうためです。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.A024]}と組んで仕事をする場合、報告・連絡・相談をしつこいくらい綿密にすると望ましいです。",
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H025]}に対して駆け引きや抜け駆け、順番飛ばしなど、仁義に悖る行為はタブーです。",
                "彼らが何かやらかした際は、関係者全員に責任があると考えて、自分の非を集団でぼかしがちなので、フォローしてあげると良いでしょう。",
            },
            new[]
            {
                "おだてたり、VIP 扱いするとすぐに靡いてしまいますので、仲良くしたい場合は積極的に活用してみましょう。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.A100]}はサプライズをするのが大好きですが、それを否定すると面子を傷つけられたと不満を持つので注意。",
                $"誰かと共同作業する際、手抜きすることは一般的に悪いことですが、{DetailedGeniusTypeName[(int)TypeDetailedGenius.A100]}との間でそれをすると、特に怒るでしょう。",
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H108]}は、心を開く前と後で性格がかなり変わるため、非常にわかりやすいです。",
                "安心させてあげると、仲良くできやすいです。",
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.E125]}に物事を提案する際、あえてリスクを先に話し、明確化することで、却って信用に繋がりやすいです。",
                "“計算高い”・“できる子”みたいにおだてられたり、“〜させて？”と下手で迫られると、流されやすい傾向があります。",
                "“〜してやるよ”みたいな、押し付けがましい態度が大嫌いです。そう言う苦手な人でもうまく付き合えるため、知らずのうちにストレスをためがちです。"
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.E555]}は自力でなんでもできてしまうがため、自分でなんでも抱えてしまいます。何かを任せる際は“やらせすぎない”よう注意すると良いでしょう。"
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H789]}へ自己紹介する際は、自分の実績を謙遜せずに明かしましょう。謙遜しすぎると“たいしたことない”と軽視されてしまいます。",
                "自分語りが長くなりがちですので、適切に話のディレクションをしてあげると効果大です。",
                "例えば初参加のイベントなど、権威を持たない門外の場所に不安を覚える傾向があります。エスコートしてあげると“その場での権威ある人”と認めてついていくようになります。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H789]}に対して、経験を否定することは避けましょう。それがたとえ誤りであっても無用の軋轢を生じさせます。",
            },
            new[]
            {
                "打たれ強い性格なので、営業職など他人に任せると気を揉んでしまいそうなポジションを任せるのもアリかもしれません。",
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.E919]}に対しては、フォーマルな付き合いは最初一回限りにして、次に会うときはカジュアルを通り越して、“チャラい”空気を作るとより心を開きやすいです。",
                "基本サボり魔ですが、その分スイッチ入った時の仕事量は凄まじいです。あまり指摘せずに見守ることが大事です。",
            },
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

    /// <summary>各素質における、弱点の解説。</summary>
    public override string[][] DetailedGeniusTypeWeakness =>
        new[]
        {
            new[]
            {
                "意識しないとメモ、フォルダー、部屋など、ありとあらゆるものが散らかっていく傾向があります。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.A000]}は、感情とパフォーマンスが非常に強くリンクする傾向があります。つまり気が向いていないと、本当に進捗しなくなります。",
            },
            new[]
            {
                "我流が強く確立しているため、臨機応変的な行動は苦手な傾向があります。",
                "他人のペースに引っ張られることを嫌うあまり、自分のペースを相手に押し付けてしまうこともあります。",
            },
            new[]
            {
                "新しいものにこだわるあまり、少々飽きっぽい印象になりがちです。",
                "出だしに遅れると、波に乗れずモチベがなかなか上がらない傾向もあります。",
                "強引な行動を受けたり、公衆の面前の前で怒られることが大嫌いです。",
                $"“人の不幸は蜜の味”とはよく言いますが、{DetailedGeniusTypeName[(int)TypeDetailedGenius.H012]}は多くの人と違い、そう言った言動を嫌います。",
            },
            new[]
            {
                "せっかちで、事細かな進捗報告がないと不安になってしまいがちです。",
                "細かい計算や立ち回りは苦手な傾向があります。",
            },
            new[]
            {
                "仲間意識の強さから、知り合いが関わっていると言うだけで、関係のないトラブルにまで首を突っ込んでしまいがちな傾向があります。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H025]}は周囲から情報を集めすぎて、収拾がつかなくなり物事の決断を鈍らせてしまう傾向があります。",
            },
            new[]
            {
                "自他共に厳しい性格が祟って、世間体を気にして冒険できない人が多いです。",
                "おだてられたり、VIP 扱いされてしまうと、ちょっと弱いかも。",
            },
            new[]
            {
                "自分で自分の行動範囲を縛って、殻に閉じこもりがちな傾向があります。",
                "自身の SNS アカウントなど、ホームポジションでは正直がすぎるあまり、相当に言葉が荒れてしまう、友達間でも馴れ馴れしくなりすぎてしまう人が多いです。",
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H108]}は一度警戒を解くと、不用意に相手を信じすぎてしまうことがあります。",
            },
            new[]
            {
                "疑り深く、物事への取り掛かりが遅くなり、スロースタートとなりがちです。",
                "反省は重要ですが、しすぎるあまり後悔とまでなってしまうことがあります。",
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.E555]}は、自分が悪くても謝罪するのを嫌がります。責任や謝罪心を持っていても、それを表明するのが極端に苦手です。",
                $"自力でやろうとなんでも抱えてしまい、結果としてパフォーマンスが落ちてしまいがちです。{DetailedGeniusTypeName[(int)TypeDetailedGenius.A100]}も同様ですが、{DetailedGeniusTypeName[(int)TypeDetailedGenius.E555]}は自力でもそこそこできてしまう器用さを持っているため、パフォーマンスが落ちていることに気づけない場合が多いです。",
                "彼らは自力なんでもできてしまうためか、他人ができないと、“どうしてこんなこともできないのか”という不快感を持つ傾向にあります。",
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.H789]}は自他問わず、実績を重視する傾向があります。そのため、自分の実績を盛り過ぎてしまう人が多いです。",
                $"一般的に、無神経で気が利かない行為はよくありませんが、{DetailedGeniusTypeName[(int)TypeDetailedGenius.H789]}はこれを特に嫌います。",
            },
            new[]
            {
                "興味があまり長続きせず、長期戦は苦手な傾向があります。",
                "話題をコロコロ変えてしまう傾向があり、もう少し話題を続けたい相手を不快にさせてしまうこともあります。",
            },
            new[]
            {
                $"{DetailedGeniusTypeName[(int)TypeDetailedGenius.E919]}は堅苦しい空気や、ぐずぐずはっきりしない態度を嫌う傾向があります。",
                "また、彼らは長期的に安定した成果を出すことが苦手です。",
            },
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

    /// <summary>性格の大分類の種別ごとの攻略法。</summary>
    public override string[][] GeniusTypesStrategies =>
        new[]
        {
            new[]
            {
                $"{GeniusTypesName[(int)TypeGenius.Authority]}・{GeniusTypesName[(int)TypeGenius.Economically]}・{GeniusTypesName[(int)TypeGenius.Humanely]}でそれぞれ三すくみのような関係があり、{GeniusTypesName[(int)TypeGenius.Economically]}より{GeniusTypesName[(int)TypeGenius.Humanely]}を説得できやすい傾向があります。",
                "話を持ちかける際は、事前に重要なところを吟味して、そこに対する<b>インパクト</b>の強さを<b>すっごい強調して説明</b>すると、話が通じやすいです。",
                $"{GeniusTypesName[(int)TypeGenius.Authority]}は、自分の抱える不安をバネにした行動力を持っています。やや邪道ですが、不安を与えてからベネフィットを提案する、<b>鞭飴</b>作戦が有効です。",
                "また、相手の<b>権威性アップ</b>をベネフィットに訴えかけると、刺さりやすいです。",
            },
            new[]
            {
                $"{GeniusTypesName[(int)TypeGenius.Authority]}・{GeniusTypesName[(int)TypeGenius.Economically]}・{GeniusTypesName[(int)TypeGenius.Humanely]}でそれぞれ三すくみのような関係があり、{GeniusTypesName[(int)TypeGenius.Humanely]}より{GeniusTypesName[(int)TypeGenius.Authority]}を説得できやすい傾向があります。",
                "話をする際は事前に重要なところを吟味して<b>要点だけ</b>を伝え、残りは質疑応答にするか資料などにして渡すなどすると、話が通じやすいです。",
                "<b>興味ある話</b>を聞くと、真剣に話を聞くあまり、怒り顔になるなど、至極<b>険悪な空気になりやすい</b>傾向があります。ここで諦めずにしっかり話すと、最後には納得してくれるケースが多いです。",
                $"{GeniusTypesName[(int)TypeGenius.Economically]}は、儲け話に対するアレルギーを持つ人が少なく、ぼかさず直球的に踏み込んでも大丈夫です。ただし<b>数値に強い</b>傾向があるため、納得のいくビジネスモデルやエビデンスを用意しないと、納得してくれないでしょう。",
            },
            new[]
            {
                $"{GeniusTypesName[(int)TypeGenius.Authority]}・{GeniusTypesName[(int)TypeGenius.Economically]}・{GeniusTypesName[(int)TypeGenius.Humanely]}でそれぞれ三すくみのような関係があり、{GeniusTypesName[(int)TypeGenius.Authority]}より{GeniusTypesName[(int)TypeGenius.Economically]}を説得できやすい傾向があります。",
                "話をする際は、<b>起承転結を順番通り</b>、冗長な補足も都度つけて説明すると話が通りやすいです。端折ると“何で？”となって、その後の話が理解できなくなりがちです。",
                $"また{GeniusTypesName[(int)TypeGenius.Humanely]}は、<b>わかってなくてもニコニコ聞いてしまう</b>ので、要所要所で確認をとるとベターでしょう。",
                "<b>人柄や、人の良さに訴えかける</b>と弱い傾向があります。また、本人のためというより、本人の周りの人のため、みたいな大義名分で攻めると説得しやすいでしょう。",
            },
        };

    /// <summary>人生観の解説。</summary>
    public override string LifeBaseDescription =>
        "人は3つの素質の他に、潜在的に持って生まれたエゴを秘めています。";

    /// <summary>人生観の見出し。</summary>
    public override string LifeBaseHeading => "人生観";

    /// <summary>人生観のタイプ別解説。</summary>
    public override string[][] LifeBaseTypesDetail =>
        new[]
        {
            new[]
            {
                "このタイプの人は、組織づくりに長けている傾向があります。",
                "親分肌で面倒見の良い人が多いです。",
            },
            new[]
            {
                "このタイプの人は、知的好奇心が人一倍強い傾向にあります。",
                "自分なりのアイデアで、その場その場を乗り切る能力に長けています。",
            },
            new[]
            {
                "このタイプの人は、鋭い感性、推理力、想像力に長けています。",
                "また正義感が強く、繊細な心の持ち主である場合が多いです。",
            },
            new[]
            {
                "このタイプの人は、話術に長ける傾向があります。",
                "自分より相手を楽しませる、そんな遊び心を潜在的に持っている人が多いです。"
            },
            new[]
            {
                "このタイプの人は、魅力的な自分でありたい欲求を持つ傾向があります。",
                "世話好きで、周囲から注目されたい欲求を持つ人が多いです。",
            },
            new[]
            {
                "このタイプの人は、数字に強く、その値の示す意味を見抜ける能力に長けています。",
                "慎重で、冷静な分析眼を持っている人が多いです。",
            },
            new[]
            {
                "このタイプの人は、自己管理能力に長けています。",
                "また、恩返しの気持ちが強い人も多いです。",
            },
            new[]
            {
                "このタイプの人は、論理的、理知的で聡明な傾向があります。",
                "古典を尊重し、先哲の開拓した学問を通した判断力に秀でています。",
            },
            new[]
            {
                "このタイプの人は、他人の話を聞きつつも、我を通すことに長ける傾向があります。",
                "仲間を組んで行動することで、物事を達成するまで妥協しない精神性を持ちます。",
            },
            new[]
            {
                "このタイプの人は、負けず嫌いな傾向があります。",
                "自分という強い芯を持ち、誰にも流されず生きることに長けています。",
            },
        };

    /// <summary>人生観のタイプ別名前一覧。</summary>
    public override string[] LifeBaseTypesName =>
        new[]
        {
            "何でも自主体験する自分でありたい",
            "とにかく行動第一な自分でありたい",
            "より完璧な自分を築き続ける自分でありたい",
            "ありのままの素直な自分でありたい",
            "コレクターな自分でありたい",
            "堅実な収集家としての自分でありたい",
            "集団の一員としての自分でありたい",
            "先人の知恵から学ぶ自分でありたい",
            "集団のリーダーな自分でありたい",
            "一匹オオカミな自分でありたい",
        };

    /// <summary>潜在能力の説明。</summary>
    public override string PotentialDescription =>
        "行動する際に発揮できる、固有の潜在能力を持っています。";

    /// <summary>潜在能力の見出し。</summary>
    public override string PotentialHeading => "潜在能力";

    /// <summary>潜在能力における、各タイプの追加解説。</summary>
    public override string[] PotentialTypeAdditional =>
        new[]
        {
            "また、0から1を作り出す能力や、他人の作品をさらに昇華したりする潜在力を持っています。",
            "逆にすでにあるものをアレンジしたり、発展させるのは不得意な傾向にあります。",
            "話し上手に聞き上手、非常にバランスのすぐれたトーク力を持っています。",
            "その一方で、聞き上手でもあり、相手の本意を聞き出せる潜在力があります。",
            "ただし集団を作ったり、集団を発展的に拡張させるのは不得意な傾向があります。",
            "几帳面で計画性があり、面倒見もよく、自己管理力もすぐれています。",
            "集団の維持は苦手な傾向があり、作ったは良いが散逸させてしまう傾向があります。",
        };

    /// <summary>潜在能力における、各タイプの解説。</summary>
    public override string[][] PotentialTypeBase =>
        new[]
        {
            new[]
            {
                "分析・応用力にすぐれ、一つのものを追求する素質を持っています。",
                "オリジナル力よりもアレンジ力を持っています。",
            },
            new[]
            {
                "一つのものをひたむきに追求できる潜在力を持っています。",
                "0 から 1 を生み出す能力、新しいものに敏感に反応できる能力もあります。",
            },
            new[]
            {
                "アーティストのような、非言語的な表現力があります。",
            },
            new[]
            {
                "能動的な、言葉による表現力があります。",
            },
            new[]
            {
                "数字の裏に隠れた意味を見抜く潜在力があります。",
                "またこのタイプの人は慎重さがあります。",
            },
            new[]
            {
                "数字・データでものを表現できる潜在力があります。",
            },
            new[]
            {
                "聞き上手で、相手の本意を聞き出せる潜在力があります。",
                "またその上で相手に自分の意思を伝える、トーク力を持っています。",
            },
            new[]
            {
                "話を聞くより伝えたい、押しの強いトーク力があります。",
                $"“{ThreeTypedGeniusName[0]}”が{DetailedGeniusTypeName[(int)TypeDetailedGenius.E001]}の人は、独裁的になる傾向もあります。",
            },
            new[]
            {
                "集団・組織を維持したり、内向きに強化できる潜在能力があります。",
                "几帳面で計画性があり、自己管理力もすぐれています。",
            },
            new[]
            {
                "集団・組織を作ったり、外向きに発展させる潜在力を持っています。",
                "面倒見の良い人が多いです。",
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

    /// <summary>3 種類の素質の解説。</summary>
    public override string[] ThreeTypedGeniusDescription =>
        new[]
        {
            "人は他に 2 種類、合計 3 種類の素質をもち、状況により現れる素質が異なります。",
            $"そのうち、“{ThreeTypedGeniusName[0]}”が<b>その人の持つ性格の殆ど</b>、80%以上を占めています。"
        };

    /// <summary>3 種類の素質の見出し。</summary>
    public override string ThreeTypedGeniusHeading => "3 種類の素質";

    /// <summary>
    /// 空のマインドキューブを挿入した際の、警告メッセージ。
    /// </summary>
    public override string WarnOnInsertTheEmptyMindCube =>
         @"診断するマインドキューブが<b>抜け殻</b>のようで、診断ができません。
お隣の部屋のマインドライターで魂の情報を書き込んでから、再度お試しください。";

    /// <summary>
    /// 無効なマインドキューブを挿入した際の短いエラーメッセージ。
    /// </summary>
    public override string WarnOnInsertTheEmptyMindCubeShort =>
        "抜け殻";

    /// <summary>ページ番号のテンプレート。</summary>
    public override string TemplatePages => "{0}/{1} ページ";

    /// <summary> 各項目における、攻略法のテンプレート。</summary>
    public override string TemplateStrategy => "{0}に対する攻略法";

    /// <summary> 各項目における、弱点のテンプレート。</summary>
    public override string TemplateWeakness => "{0}の弱点";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public override string TemplateYourType => "あなたの{0}";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public override string TemplateYourTypeIs => "あなたは<b>{0}</b>です！";

    /// <summary>説明サイズ。</summary>
    public override int SizeDescription => 23;

    /// <summary>詳細サイズ。</summary>
    public override int SizeDetails => 23;

    /// <summary>見出しサイズ。</summary>
    public override int SizeHeading => 40;

    /// <summary>説明サイズ。</summary>
    public override int SizeLine => 85;

    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Japanese;
}
