using UdonSharp;

/// <summary>フォールバック言語用テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class FallbackResources : UdonSharpBehaviour
{
    /// <summary>
    /// 3 種類の素質ページの文言のうち、
    /// 固定部分のビルド済みページを取得します。
    /// </summary>
    public string Built3TypedGeniusFixedPart { get; protected set; }

    /// <summary>
    /// 3 種類の素質ページの文言のビルド済みページを取得します。
    /// </summary>
    public string[] Built3TypedGenius { get; protected set; }

    /// <summary>
    /// 論理思考タイプの分類別ビルド済みページ一覧を取得します。
    /// </summary>
    public string[] BuiltBrains { get; protected set; }

    /// <summary>
    /// 対話思考タイプの分類別ビルド済みページ一覧を取得します。
    /// </summary>
    public string[] BuiltCommunications { get; protected set; }

    /// <summary>性格の大分類別ビルド済みページ一覧を取得します。</summary>
    public string[] BuiltGenius { get; protected set; }

    /// <summary>
    /// 性格の大分類別攻略法のビルド済みページ一覧を取得します。
    /// </summary>
    public string[] BuiltGeniusStrategy { get; protected set; }

    /// <summary>素質タイプ別のビルド済みページ一覧を取得します。</summary>
    public string[] BuiltDetailedGeniusType { get; protected set; }

    /// <summary>素質タイプ別のビルド済みページ一覧を取得します。</summary>
    public string[] BuiltDetailedGeniusWeakness { get; protected set; }

    /// <summary>素質タイプ別のビルド済みページ一覧を取得します。</summary>
    public string[] BuiltDetailedGeniusStrategy { get; protected set; }

    /// <summary>人生観別のビルド済みページ一覧を取得します。</summary>
    public string[] BuiltLifebase { get; protected set; }

    /// <summary>潜在能力別のビルド済みページ一覧を取得します。</summary>
    public string[][] BuiltPotentials { get; protected set; }

    /// <summary>潜在能力別のビルド済み特徴一覧を取得します。</summary>
    public string[][][] BuiltPotentialDetails { get; protected set; }

    /// <summary>
    /// 応対思考タイプの分類別ビルド済みページ一覧を取得します。
    /// </summary>
    public string[] BuiltResponses { get; protected set; }

    /// <summary>論理思考タイプの見出しメッセージ。</summary>
    public virtual string BrainDescription =>
        $"Depending on the person, they can divide into the “{BrainTypeHeading[(int)TypeBrain.Left]}” type or the “{BrainTypeHeading[(int)TypeBrain.Right]}” type.";

    /// <summary>論理思考タイプの見出しメッセージ。</summary>
    public virtual string BrainHeading => "Thinking methods";

    /// <summary>論理思考タイプのタイプ別コピー。</summary>
    public virtual string[] BrainTypeCopy =>
        new[]
        {
            "They are excellent at <b>logical</b> thinking.",
            "They are excellent at <b>intuitive</b> thinking.",
        };

    /// <summary>論理思考タイプのタイプ別解説。</summary>
    public virtual string[][] BrainTypeDetails =>
        new[]
        {
            new[]
            {
                "While they are good at thinking based on numbers and data, they tend to confuse in rambling situations.",
                "They tend to stick to numerical evidence and are not good at working intuitively.",
            },
            new[]
            {
                "While they're <b>good at using imagination</b>, such as brainstorming, They tend to disregard the evidence and move with intuition first.",
                "In <b>complicated situations</b>, they are <b>easy to stop thinking</b>.",
            },
        };

    /// <summary>論理思考タイプのタイプ別名称。</summary>
    public virtual string[] BrainTypeHeading =>
        new[] { "Left-brained thinking", "Right-brained thinking" };

    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public virtual string ComingSoon =>
         "We'll be adding more clairvoyant results in the future!";

    /// <summary>対話思考タイプの見出しメッセージ。</summary>
    public virtual string CommunicationDescription =>
        $"Depending on the person, they can divide into the “{CommunicationTypeHeading[(int)TypeCommunication.Fix]}” type or the “{CommunicationTypeHeading[(int)TypeCommunication.Flex]}” type.";

    /// <summary>対話思考タイプの見出しメッセージ。</summary>
    public virtual string CommunicationHeading => "Ways of thinking in dialogue";

    /// <summary>対話思考タイプのタイプ別コピー。</summary>
    public virtual string[] CommunicationTypeCopy =>
        new[]
        {
            "They do dialogue that proceeds with a conclusion.",
            "They are good at concluding <b>fluidly</b>.",
        };

    /// <summary>対話思考タイプのタイプ別解説。</summary>
    public virtual string[][] CommunicationTypeDetails =>
        new[]
        {
            new[]
            {
                "They tend to rationalize and get their point across.",
                "They are relieved when things are clearly defined, such as time and place, but tend to feel uneasy when things are unclear.",
            },
            new[]
            {
                "They also tend to use emotionalism to get their point across.",
                "They can manage with ambiguity in terms of time, place, etc., but they <b>feel constrained when it comes to clarity</b>.",
            },
        };

    /// <summary>対話思考タイプのタイプ別名称。</summary>
    public virtual string[] CommunicationTypeHeading =>
        new[] { "<b>Fix</b>: Clarification-oriented", "<b>Flex</b>: Liquidity-oriented" };

    /// <summary>素質の解説。</summary>
    public virtual string DetailedGeniusDescription =>
        "A more detailed, innate personality. This is classified into 12 types.";

    /// <summary>素質の見出し。</summary>
    public virtual string DetailedGeniusHeading => "The genius";

    /// <summary>各素質の解説。</summary>
    public virtual string[][] DetailedGeniusTypeDetails =>
        new[]
        {
            new[]
            {
                "They have a hyper-linguistic philosophy; and an outlandish worldview. Some people describe them as the sixth senses.",
                "However, they are not very dynamic, and many of them keep it in their heads.",
                "It is also common for sensitive types to go on a trip without a plan and lose touch.",
            },
            new[]
            {
                "They love to act like a weirdo, untainted by the ideas of others.",
                "They like individualism and prefer to work at their own pace.",
                "They are the best actors to play the role of “well thought out idiot”.",
            },
            new[]
            {
                "They have a youthful temperament, always like middle-teens, even when they grow up.",
                "They tend to like to discuss, but this tends to be a long story with little substance.",
                "While they are eager to be in front of the public, they are also good at supporting the whole process behind the scenes.",
            },
            new[]
            {
                "Once they just thought about anything, they are hard-working and determined to finish it, but they are not good at planning detailed strategies.",
                "They are usually mild-mannered but cannot wait for things to happen.",
                $"The “{GeniusTypesName[(int)TypeGenius.Authority]}” people, in general, have the gift of being able to turn anxiety into a driving force for action, but they are especially adept at it.",
                "They can memorize and act as if they already knew something ten years ago, even if they have just learned it for the first time.",
            },
            new[]
            {
                "They have a sense of brotherhood with all humankind and have the qualities to get along equally and equally.",
                "But, on the other hand, because they are “equally friendly”, they will always make a hedge, even with family members.",
                "They tend to become well informed because they have a lot of connections.",
            },
            new[]
            {
                "They like to pretend that they are not good at something, but they want to surprise and stand out by being prepared.",
                "They tend to take on everything, trying to do it on their own.",
            },
            new[]
            {
                "They are often as straightforward and honest as a baby.",
                "They are very shy, and they become reticent when thrown into a place full of strangers.",
            },
            new[]
            {
                "They have big, romantic dreams.",
                "Also, like older adults, they have a long view of life and have the aptitude to be stoic in the short term.",
            },
            new[]
            {
                "Many people have an air of all-around competence and boss authority, like an executive employee.",
                "They can get used to something faster than others, even if they have no experience.",
                "But it takes several times more effort than other types to become an expert in their field. In other words, they are suitable for generalists rather than experts."
            },
            new[]
            {
                "They have the humble yet imposing spirit of a company president.",
                $"They have the near qualities as type “{GeniusTypesName[(int)TypeGenius.Authority]}”. They have can weigh the authority of others and see the real thing.",
                "They have a keen eye for weighing the authority of others and detecting the real thing, and they never fail to improve themselves to make their authority more solid.",
                "While they are good at being unsung heroes, they also like to get in front of people when the time is right and skim the cream.",
            },
            new[]
            {
                "They are like boys and girls with a challenging nature, interested in every direction.",
                "Many of them are so hard-hitting that they don't even realize they've been beaten.",
            },
            new[]
            {
                "While they have a tremendous amount of concentration, they are always lazy the rest of the time.",
                "Many of them have a strong disposition to whatever it takes to get whatever they want and the skills to bargain for it.",
                "They are good at negotiating and have the makings of a salesperson.",
            },
        };

    /// <summary>各素質の見出し。</summary>
    public virtual string[] DetailedGeniusTypeName =>
        new[]
        {
            "Spiritual type",
            "Maverick type",
            "Early Adopters type",
            "Effortist type",
            "Saintist type",
            "Perfectionism type",
            "Naturalism type",
            "Romantic type",
            "Easygoing type",
            "Authority type",
            "Challenger type",
            "Socialize type",
        };

    /// <summary>各素質に対する、攻略法の解説。</summary>
    public virtual string[][] DetailedGeniusTypeStrategy =>
        new[]
        {
            new[]
            {
                "They do hate any restraint, bondage, or rules.",
                "When they say “Roger!”, but they tend to don't understand yet the request. So it is a good idea to check with them to avoid problems later on.",
                "If you are going to do something with a group of people, it is best to put them in a position to be asked to be creative.",
            },
            new[]
            {
                "They don't like to be paced by others, so they may be challenging to get to know at first sight, but they will be kind to you once you know them.",
                "In general, seeing the other person with strange eyes is considered a bad thing, but they are exceptions and can use as compliments.",
                "On the other hand, words such as “unoriginal” or “common sense” can be bad words to them, so be careful.",
                "When working in a group, they perform best when put in positions requiring them to be creative.",
            },
            new[]
            {
                "“It's the latest news” and “No one knows about it yet” are powerful words to get their attention.",
                "On the other hand, worn-out or stable somethings may discourage their interest.",
            },
            new[]
            {
                "They are impatient and tend to get anxious if they don't get detailed progress reports.",
                "They tend not to be good at detailed calculations or standing around.",
            },
            new[]
            {
                "It's taboo to try outfoxing with them, leave them out, skip their turn, or do anything that is not honorable.",
                "They tend to think equally responsible for all involved and blur their responsibilities collectively, so it is best to follow through.",
            },
            new[]
            {
                "They are influencing by flattery and VIP treatment.",
                "They love to surprise you, but be aware that they will complain that they lost face if you deny them.",
            },
            new[]
            {
                "They are straightforward to understand, as their personalities change considerably before and after they open up.",
                "If you make them feel at ease, it is easy to get along with them.",
            },
            new[]
            {
                "When proposing things to them, it is easier to trust if you talk about the risks first and clarify them.",
                "If you suggest things to them in a humble way, they tend to influence easily.",
                "They hate intrusive attitudes from above. They can get along well with those who are not so good at it and tend to stress you out without even knowing it.",
            },
            new[]
            {
                "They can do everything on their own, so they tend to take care of everything on their own. When you entrust them with something, be careful not to let them do too much.",
            },
            new[]
            {
                "When you introduce yourself to them, don't be modest about your achievements. They will take you at your word and disregard you.",
                "They tend to talk about themselves for a long time, so it is very effective to direct their conversation appropriately.",
                "They tend to be apprehensive about places where they have no authority, such as an event they attend for the first time. However, if you escort them, they will recognize you as the “authority” in the situation and follow you.",
                "Avoid denying their experience straightforward to them. Even if their expertise is wrong, they will anger.",
            },
            new[]
            {
                "Because of their hard-hitting nature, it may be a good idea to entrust them with positions that might make them fret if left to others, in addition to being salespeople.",
            },
            new[]
            {
                "It's easier to open up to them if you limit the formalities to the first meeting and create a funky atmosphere the next time you meet.",
                "They are slackers, but when they are motivated, they do a tremendous amount of work. For this reason, it is essential to let them do their job without pointing out how to do it in detail.",
            },
        };

    /// <summary>各素質のキャッチコピー。</summary>
    public virtual string[] DetailedGeniusTypeSummary =>
        new[]
        {
            "They prefer aimless wandering and utilize sharp intuition and flashes of inspiration",
            "“Eccentric”, or “Weird” words are a compliment for them! They do in their way like a lone wolf",
            "They are early adopters who love new things and pursue freshness every day",
            "They are impatient and have a strong drive",
            "They are people who love others and are well-informed personalities",
            "They are severe and stubborn, like a top-notch businessperson who doesn't show weakness!",
            "They are shy, but once you get used to them, they are honest to a fault",
            "No rival in dreams and self-discipline! Straight to the goal in the long run",
            "Balanced, capable and caring, a heroic position",
            "A talented person who is good at dividing roles by respecting achievements and experience",
            "They are naive and curious! They don't care if something doesn't work; they will keep trying",
            "They are good negotiators and prefer short-term strategy",
        };

    /// <summary>各素質における、弱点の解説。</summary>
    public virtual string[][] DetailedGeniusTypeWeakness =>
        new[]
        {
            new[]
            {
                "They tend to clutter up their notes, folders on their desktops, rooms, and everything else if they are not aware.",
                "They tend to have a strong link between their emotions and their performance. In other words, if they are not in the right frame of mind, they will not make progress.",
            },
            new[]
            {
                "They tend to do it in their way and not very resourceful.",
                "They do not like to be pulled along by the pace of others and may impose their own pace on others.",
            },
            new[]
            {
                "They always like new things, but it's no longer new for them once they know anything. So, they tend to get bored quickly.",
                "If they have trouble getting started, they tend to lose motivation for even required things.",
                "They hate intensely to be forced action or angered in front of the public.",
                "Many peoples say that “Schadenfreude, Take pleasure in the misery of others”. But they are different, and they hate it.",
            },
            new[]
            {
                "They are impatient and tend to get anxious if they don't get detailed progress reports.",
                "They tend not to be good at detailed calculations or standing around.",
            },
            new[]
            {
                "They have a strong sense of camaraderie, so when someone they know gets into trouble, they tend to nose into problems with them.",
                "Their judgment starts to weaken because they tend to gather too much information from their surroundings.",
            },
            new[]
            {
                "They tend to be hard on themselves and others and are too concerned about public opinion to take challenging actions.",
                "They are influencing by flattery and VIP treatment.",
                "When collaborating with someone, cutting corners is generally a bad thing, but doing it with them will make you especially angry.",
            },
            new[]
            {
                "They tend to restrict themselves to their sphere of activity and tend to stay in their shells.",
                "They tend to be too honest in their home positions, such as social networking sites, and many of them become verbally abusive and overly familiar even among their friends.",
                "Once they let their guard down, they may needlessly trust the other person too much.",
            },
            new[]
            {
                "They are skeptical and tend to be slow to take things on.",
                "Reflection is critical, but for them, it can lead to regret because of too much.",
            },
            new[]
            {
                "They don't like to apologize even when it is their fault. Even if they have apologetic, they are not very good at expressing it.",
                "Perhaps because they can do everything on their own, they tend to feel uncomfortable when others can't, wondering why they can't do such things.",
                $"They tend to take on everything in an attempt to do it on their own, and as a result, their efficiency becomes less. The same is true for the “{DetailedGeniusTypeName[(int)TypeDetailedGenius.A100]}” but since the “{DetailedGeniusTypeName[(int)TypeDetailedGenius.E555]}” has the dexterity to do so much on their own, they often don't notice that their performance is declining.",
            },
            new[]
            {
                "They tend to focus on achievements and authority, whether their own or others, So, they tend to overestimate themselves.",
                "In general, insensitive and unkind behavior isn't good, but they especially dislike this.",
            },
            new[]
            {
                "Their interests don't last very long, and they tend not to be good at long-term bargaining.",
                "They tend to change topics frequently. But others often want to continue the issue a little longer, so they may make others uncomfortable.",
            },
            new[]
            {
                "They tend to be uncomfortable with the formal atmosphere and unclear attitude.",
                "They are also not very good at producing stable results in the long term.",
            },
        };

    /// <summary>性格の大分類の説明。</summary>
    public virtual string GeniusDescription =>
        $"There are three main types of humans personality: “{GeniusTypesName[(int)TypeGenius.Authority]}”, “{GeniusTypesName[(int)TypeGenius.Economically]}”, and “{GeniusTypesName[(int)TypeGenius.Humanely]}”.";

    /// <summary>性格の大分類の見出し。</summary>
    public virtual string GeniusHeading =>
        "Major categories of personality";

    /// <summary>性格の大分類の種別ごとの見出し。</summary>
    public virtual string[] GeniusTypesName =>
        new[]
        {
            "Focused on authority",
            "Focused on economically",
            "Focused on humanely",
        };

    /// <summary>性格の大分類の種別ごとの説明。</summary>
    public virtual string[][] GeniusTypesDetails =>
        new[]
        {
            new[]
            {
                "They have an underlying <b>ego for their authority</b>and a personality that <b>pursues their future potential</b>.",
                $"They cannot listen to long talks. As soon as they decide that something is not essential, they blatantly stop listening to the conversation, such as playing with their phones or dozing off.",
                $"People who collect brand-name goods to dress up for their authority tend to have this personality type.",
                "They tend to have vague, hard-to-realize anxieties and tend to transfer them to their driving force.",
            },
            new[]
            {
                "This personality type is the pursues efficiency, with the underlying ego being for the <b>sake of one's own wealth</b>.",
                "They tend to be specs-oriented and tend to disrespect brands. However, some rare people consider brands to be a kind of specs and place importance on them.",
                $"<b>They cannot listen to long conversations</b> very well. So they try to understand <b>only the main points</b> and tend to think or say, “<b>in a nutshell...</b>”.",
            },
            new[]
            {
                "They pursue sociality with an ego to <b>improve their virtue</b>.",
                "They tend to focus on personality in many things. For example, when choosing a product at a store or something, they tend to decide based on the salesperson's character than its quality.",
                $"They tend to <b>be able to listen to long conversations</b> from beginning to end with a smile. However, they <b>can't always understand to gist</b>.",
                "If you only get to the point briefly, they will be curious about the introduction, development of the story and not understanding its rest.",
            },
        };

    /// <summary>性格の大分類の種別ごとの攻略法。</summary>
    public virtual string[][] GeniusTypesStrategies =>
        new[]
        {
            new[]
            {
                $"There is a relationship like the rock-paper-scissors between the “{GeniusTypesName[(int)TypeGenius.Authority]}” type, “{GeniusTypesName[(int)TypeGenius.Economically]}” type, and “{GeniusTypesName[(int)TypeGenius.Humanely]}” type. They are easier to talk to the “{GeniusTypesName[(int)TypeGenius.Humanely]}” type than the “{GeniusTypesName[(int)TypeGenius.Economically]}” type.",
                "When approaching someone for a talk, it is easier to get through to them if you examine the essential points beforehand and explain them with <b>great emphasis on their impact</b>.",
                "They have the power to act on their insecurities. So <b>the carrot and stick method</b>, where you give them anxiety and then propose benefits, is compelling.",
                "Also, if you appeal to them <b>to increase their authority</b>, they are more likely to be influenced.",
            },
            new[]
            {
                $"There is a relationship like the rock-paper-scissors between the “{GeniusTypesName[(int)TypeGenius.Authority]}” type, “{GeniusTypesName[(int)TypeGenius.Economically]}” type, and “{GeniusTypesName[(int)TypeGenius.Humanely]}” type. They are easier to talk to the “{GeniusTypesName[(int)TypeGenius.Authority]}” type than the “{GeniusTypesName[(int)TypeGenius.Humanely]}” type.",
                "When giving a talk to them, they are easier to get through if you <b>examine the essential points beforehand</b> and briefly present the main points, leaving the rest for questions and answers or handing out materials.",
                "They look like to get <b>strong angry</b> when they <b>hear something that interests them</b>. However, they are <b>only listening seriously</b> and are <b>usually not angry</b>, so it is essential to endure the bitter atmosphere when talking with them.",
                "They are less allergic to talk of profit, so it is okay to go straight to the point without blurting it out. However, since they tend to be shrewd about numbers, you will not convince them unless you provide a convincing business model and evidence.",
            },
            new[]
            {
                $"There is a relationship like the rock-paper-scissors between the “{GeniusTypesName[(int)TypeGenius.Authority]}” type, “{GeniusTypesName[(int)TypeGenius.Economically]}” type, and “{GeniusTypesName[(int)TypeGenius.Humanely]}” type. They are easier to talk to the “{GeniusTypesName[(int)TypeGenius.Economically]}” type than the “{GeniusTypesName[(int)TypeGenius.Authority]}” type.",
                "When talking to them, you can get through to them easier if you explain the story <b>in order</b>, with a few <b>redundant additions</b> each time.",
                "They also tend to listen smilingly even if they don't understand, so it is more desirable to ask for confirmation at crucial points.",
                "They have a tendency to be easily influenced when they are praised for their kindness and humanity. Also, it is easier to persuade them if you talk to them with a cause that is not for their own sake but for the sake of the people around them.",
            },
        };

    /// <summary>人生観の解説。</summary>
    public virtual string LifeBaseDescription =>
        "Peoples also have a latent ego that they are born with, in addition to the three personalities.";

    /// <summary>人生観の見出し。</summary>
    public virtual string LifeBaseHeading => "View of life";

    /// <summary>人生観のタイプ別解説。</summary>
    public virtual string[][] LifeBaseTypesDetail =>
        new[]
        {
            new[]
            {
                "This type of person tends to be good at building organizations.",
                "They are also more likely to be custodial and caring.",
            },
            new[]
            {
                "This type of person tends to be more intellectually curious than others.",
                "They have a remarkable ability to come up with their ideas to get them through the moment.",
            },
            new[]
            {
                "This type of person has a keen sense of sensitivity, reasoning ability, and imagination.",
                "They also have a strong sense of justice and are often sensitive minds.",
            },
            new[]
            {
                "This type of person tends to be a good talker.",
                "In addition, they tend to have a playful spirit that makes the other person more entertained than themselves.",
            },
            new[]
            {
                "This type of person tends to have a desire to be attractive.",
                "In addition, they are also caring people, and many have a desire to be noticed by those around them.",
            },
            new[]
            {
                "This type of person is strong with numbers and has a remarkable ability to see the meaning of the values they represent.",
            },
            new[]
            {
                "This type of person has excellent self-discipline.",
                "Many of them also have a strong mind of giving back.",
            },
            new[]
            {
                "This type of person tends to be logical, intelligent, and quick-witted.",
                "They respect the classics and excel at making decisions through the studies pioneered by earlier philosophers.",
            },
            new[]
            {
                "This type of person tends to be skilled at asserting their will while listening to others.",
                "They also work in teams of friends and have an uncompromising mentality until things are accomplished.",
            },
            new[]
            {
                "This type of person tends to be competitive.",
                "They have a strong sense of self and are good at living without being influenced by others.",
            },
        };

    /// <summary>人生観のタイプ別名前一覧。</summary>
    public virtual string[] LifeBaseTypesName =>
        new[]
        {
            "would like to be the one who experiences everything myself.",
            "would like to do it immediately when they think.",
            "would like to be perfectionists.",
            "would like to be honest with themselves.",
            "would like to put everything within eye reach.",
            "would like to be a down-to-earth collector.",
            "would like to live as a member of a group.",
            "would like to learn from the wisdom of their pioneers.",
            "would like to be the leader of the group always.",
            "would like to be a lone wolf.",
        };

    /// <summary>潜在能力の説明。</summary>
    public virtual string PotentialDescription =>
        "People have inherent potentials that they can exercise when they act.";

    /// <summary>潜在能力の見出し。</summary>
    public virtual string PotentialHeading => "Potentials";

    /// <summary>潜在能力における、各タイプの追加解説。</summary>
    public virtual string[] PotentialTypeAdditional =>
        new[]
        {
            "They also can create from nothing and the potential to sublimate the work of others.",
            "On the other hand, they tend not to be good at arranging or developing what is already there.",
            "This type of person is both a good talker and a good listener and has a well-balanced ability to talk.",
            "On the other hand, they are also good listeners and can find out what the other person is thinking.",
            "However, they tend not to be good at creating new teams or developing and expanding their groups.",
            "They are meticulous, organized, caring, and have excellent self-management skills.",
            "They tend not to be good at maintaining groups, and even when they create them, they tend to disappear spontaneously.",
        };

    /// <summary>潜在能力における、各タイプの解説。</summary>
    public virtual string[][] PotentialTypeBase =>
        new[]
        {
            new[]
            {
                "This type of person has excellent analytical and application skills and has a predisposition to pursue one thing at a time.",
                "They have the power of arrangement rather than the power of originality.",
            },
            new[]
            {
                "This type of person has the potential to pursue one thing relentlessly.",
                "They also can create something out of nothing and be sensitive to new things.",
            },
            new[]
            {
                "This type of person can express themselves thinks, in a nonverbal way, like an artist.",
            },
            new[]
            {
                "This type of person can express themselves think actively through words.",
            },
            new[]
            {
                "This type of person has the potential to see the hidden meaning behind the numbers.",
                "They also try to do things carefully.",
            },
            new[]
            {
                "This type of person has the potential to express things with numbers and data.",
            },
            new[]
            {
                "This type of person is a good listener and can find out what the other person is thinking.",
                "They then can talk and convey their intentions to the other person.",
            },
            new[]
            {
                "This type of person is a pushy talker who would instead tell a story than listen to it.",
                $"Furthermore, those of them whose inner personality is “{DetailedGeniusTypeName[(int)TypeDetailedGenius.E001]}” tend to be dictatorial.",
            },
            new[]
            {
                "This type of person has the potential to maintain or inwardly solidify a group or organization.",
                "They are organized, well-planned, and have excellent self-management skills.",
            },
            new[]
            {
                "This type of person has the potential to create groups and organizations and develop them outwardly.",
                "They are also often very caring people.",
            },
        };

    /// <summary>応対思考タイプの見出しメッセージ。</summary>
    public virtual string ResponseDescription =>
        $"Depending on the person, they can divide into the “{ResponseTypeHeading[(int)TypeResponse.Action]}” type or the “{ResponseTypeHeading[(int)TypeResponse.Mind]}” type.";

    /// <summary>応対思考タイプの見出しメッセージ。</summary>
    public virtual string ResponseHeading => "Suitability for the work";

    /// <summary>応対思考タイプのタイプ別コピー。</summary>
    public virtual string[] ResponseTypeCopy =>
        new[]
        {
            "They focus on putting energy into action and feel that their place is at the forefront of on-site.",
            "They value putting energy into thinking and feel that performing a role behind the scenes is valuable.",
        };

    /// <summary>応対思考タイプのタイプ別解説。</summary>
    public virtual string[][] ResponseTypeDetails =>
        new[]
        {
            new[]
            {
                "They tend to may <b>act before thinking</b>.",
                "A group of people with the same personality type as them in proportion will give the impression of being unstable yet active.",
                "While they are good at public appearances, many of them get easily choked up by behind-the-scenes work such as office work, manufactures, or machine operation.",
            },
            new[]
            {
                "They are more of a thinker before acting type.",
                "A group with a proportion of their type of people will look stagnant, but it will give the impression of being down-to-earth and solid.",
                "While they are good at clerical work, manufacturing, and machine operation, they are not good at meeting in person, and many of them get tired of work in public easily.",
            },
        };

    /// <summary>応対思考タイプのタイプ別名称。</summary>
    public virtual string[] ResponseTypeHeading =>
        new[] { "Get out in public", "Behind the scenes work" };

    /// <summary>3 種類の素質の名前。</summary>
    public virtual string[] ThreeTypedGeniusName =>
        new[] { "Inner", "Outer", "Workstyle" };

    /// <summary>3 種類の素質の各解説。</summary>
    public virtual string[] ThreeTypedGeniusTypesDescription =>
        new[]
        {
            "the underlying personality",
            "the personality that comes out when you don't trust the other person",
            "the personality when you are focused or in an emergency"
        };

    /// <summary>3 種類の素質の解説。</summary>
    public virtual string[] ThreeTypedGeniusDescription =>
        new[]
        {
            "A person has 3 of these personalities, and the personality that emerges varies depending on the situation.",
            $"Of these, “{ThreeTypedGeniusName[0]}” accounts for most of a person's personality.",
        };

    /// <summary>3 種類の素質の見出し。</summary>
    public virtual string ThreeTypedGeniusHeading => "3 geniuses";

    /// <summary>
    /// 空のマインドキューブを挿入した際の、警告メッセージ。
    /// </summary>
    public virtual string WarnOnInsertTheEmptyMindCube =>
         @"The Mind Cube, used to clairvoyance your personality, is <b>empty</b>.
Since clairvoyant is impossible in this state, please write your information in the Mind Writer in the previous room and try again.";

    /// <summary>
    /// 無効なマインドキューブを挿入した際の短いエラーメッセージ。
    /// </summary>
    public virtual string WarnOnInsertTheEmptyMindCubeShort =>
        "Invalid cube";

    /// <summary>ページ番号のテンプレート。</summary>
    public virtual string TemplatePages => "Pages: {0}/{1}";

    /// <summary> 各項目における、攻略法のテンプレート。</summary>
    public virtual string TemplateStrategy =>
        "Strategies for the “<b>{0}</b>”type";

    /// <summary> 各項目における、弱点のテンプレート。</summary>
    public virtual string TemplateWeakness =>
        "Weaknesses of the “<b>{0}</b>”type";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public virtual string TemplateYourType => "Your {0}";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public virtual string TemplateYourTypeIs =>
        "Your type is“<b>{0}</b>”!";

    /// <summary>説明サイズ。</summary>
    public virtual int SizeDescription => 20;

    /// <summary>詳細サイズ。</summary>
    public virtual int SizeDetails => 20;

    /// <summary>見出しサイズ。</summary>
    public virtual int SizeHeading => 32;

    /// <summary>行サイズ。</summary>
    public virtual int SizeLine => 72;

    /// <summary>言語種別。</summary>
    public virtual TypeLanguage Type => TypeLanguage.English;

    /// <summary>潜在能力のタイプ別解説を作成します。</summary>
    /// <returns>潜在能力のタイプ別解説。</returns>
    private string[][][] CreatePotentialTypeDetails()
    {
        string[] a = PotentialTypeAdditional;
        string[][] b = PotentialTypeBase;
        string[][][] result =
            new string[(int)TypePotential.MAX_VALUE][][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new string[(int)TypePotential.MAX_VALUE][];
            for (int j = 0; j < result[i].Length; j++)
            {
                result[i][j] = i == j ? b[i] : ArrayUtils.Join(b[i], b[j]);
            }
        }
        string[] CiCo = ArrayUtils.Flatten(
            new[] { b[(int)TypePotential.Ci][0] }, new[] { a[0] });
        string[] CoCo = ArrayUtils.Flatten(
            b[(int)TypePotential.Co], new[] { a[1] });
        string[] IiIo = ArrayUtils.Flatten(
            new[] { a[2] },
            new[] { b[(int)TypePotential.Io][0] },
            new[] { a[3] });
        string[] NiNi = ArrayUtils.Flatten(
            new[] { b[(int)TypePotential.Ni][0] },
            new[] { a[4] },
            new[] { b[(int)TypePotential.Ni][1] });
        string[] NiNo = ArrayUtils.Flatten(
            new[] { b[(int)TypePotential.Ni][0] },
            new[] { b[(int)TypePotential.No][0] },
            new[] { a[5] });
        string[] NoNo = ArrayUtils.Flatten(
            new[] { b[(int)TypePotential.No][0] },
            new[] { a[6] },
            new[] { b[(int)TypePotential.No][1] });
        result[(int)TypePotential.Ci][(int)TypePotential.Co] = CiCo;
        result[(int)TypePotential.Co][(int)TypePotential.Ci] = CiCo;
        result[(int)TypePotential.Co][(int)TypePotential.Co] = CoCo;
        result[(int)TypePotential.Ii][(int)TypePotential.Io] = IiIo;
        result[(int)TypePotential.Io][(int)TypePotential.Ii] = IiIo;
        result[(int)TypePotential.Ni][(int)TypePotential.Ni] = NiNi;
        result[(int)TypePotential.Ni][(int)TypePotential.No] = NiNo;
        result[(int)TypePotential.No][(int)TypePotential.Ni] = NiNo;
        result[(int)TypePotential.No][(int)TypePotential.No] = NoNo;
        return result;
    }

#pragma warning disable IDE0051
    /// <summary>初期化時に呼び出す、コールバック。</summary>
    private void Start()
    {
        BuiltPotentialDetails = CreatePotentialTypeDetails();

        BuiltBrains = new string[(int)TypeBrain.MAX_VALUE];
        for (int i = (int)TypeBrain.MAX_VALUE; --i >= 0;)
        {
            BuiltBrains[i] = this.CreateBrainPage(i);
        }
        BuiltCommunications = new string[(int)TypeCommunication.MAX_VALUE];
        for (int i = (int)TypeCommunication.MAX_VALUE; --i >= 0;)
        {
            BuiltCommunications[i] = this.CreateCommunicationPage(i);
        }
        BuiltResponses = new string[(int)TypeResponse.MAX_VALUE];
        for (int i = (int)TypeResponse.MAX_VALUE; --i >= 0;)
        {
            BuiltResponses[i] = this.CreateResponsePage(i);
        }
        Built3TypedGeniusFixedPart = this.Create3GeniusPageFixedPart();
        BuiltGenius = new string[(int)TypeGenius.MAX_VALUE];
        BuiltGeniusStrategy = new string[(int)TypeGenius.MAX_VALUE];
        for (int i = (int)TypeGenius.MAX_VALUE; --i >= 0;)
        {
            BuiltGenius[i] = this.CreateGeniusPage(i);
            BuiltGeniusStrategy[i] = this.CreateGeniusStrategyPage(i);
        }
        Built3TypedGenius = new string[(int)TypeDetailedGenius.MAX_VALUE];
        BuiltDetailedGeniusType =
            new string[(int)TypeDetailedGenius.MAX_VALUE];
        BuiltDetailedGeniusWeakness =
            new string[(int)TypeDetailedGenius.MAX_VALUE];
        BuiltDetailedGeniusStrategy =
            new string[(int)TypeDetailedGenius.MAX_VALUE];
        for (int i = (int)TypeDetailedGenius.MAX_VALUE; --i >= 0;)
        {
            Built3TypedGenius[i] = this.Create3GeniusPage(i);
            BuiltDetailedGeniusType[i] = this.CreateDetailedGeniusPage(i);
            BuiltDetailedGeniusWeakness[i] =
                this.CreateDetailedGeniusWeaknessPage(i);
            BuiltDetailedGeniusStrategy[i] =
                this.CreateDetailedGeniusStrategyPage(i);
        }
        BuiltLifebase = new string[(int)TypeLifebase.MAX_VALUE];
        for (int i = (int)TypeLifebase.MAX_VALUE; --i >= 0;)
        {
            BuiltLifebase[i] = this.CreateLifeBasePage(i);
        }
        BuiltPotentials = new string[(int)TypePotential.MAX_VALUE][];
        for (int i = (int)TypePotential.MAX_VALUE; --i >= 0;)
        {
            BuiltPotentials[i] = new string[(int)TypePotential.MAX_VALUE];
            for (int j = (int)TypePotential.MAX_VALUE; --j >= 0;)
            {
                BuiltPotentials[i][j] = this.CreatePotentialPage(i, j);
            }
        }
    }
#pragma warning restore IDE0051
}
