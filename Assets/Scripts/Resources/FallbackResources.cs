using UdonSharp;

/// <summary>フォールバック言語用テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class FallbackResources : UdonSharpBehaviour
{
    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public virtual string ComingSoon =>
         "We'll be adding more clairvoyant results in the future!";

    /// <summary>素質の解説。</summary>
    public virtual string DetailedGeniusDescription =>
        "A more detailed, innate personality. This is classified into 12 types.";

    /// <summary>素質の見出し。</summary>
    public virtual string DetailedGeniusHeading => "Type of genius";

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
                "But, on the other hand, because they are “equally friendly,” they will always make a hedge, even with family members.",
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

    /// <summary>各素質のキャッチコピー。</summary>
    public virtual string[] DetailedGeniusTypeSummary =>
        new[]
        {
            "They prefer aimless wandering and utilize sharp intuition and flashes of inspiration.",
            "“Eccentric”, “Freak”, or “Weird” words are a compliment for them! They do in their way like a lone wolf.",
            "They are early adopters who love new things and pursue freshness every day.",
            "They are impatient and have a strong drive.",
            "They are people who love others and are well-informed personalities.",
            "They are severe and stubborn, like a top-notch businessperson who doesn't show weakness!",
            "They are shy, but once you get used to them, they are honest to a fault.",
            "No rival in dreams and self-discipline! Straight to the goal in the long run.",
            "Balanced, capable and caring, a heroic position.",
            "A talented person who is good at dividing roles by respecting achievements and experience.",
            "They are naive and curious! They don't care if something doesn't work; they will keep trying.",
            "They are good negotiators and prefer short-term strategy.",
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

    /// <summary>
    /// 空のマインドキューブを挿入した際の、警告メッセージ。
    /// </summary>
    public virtual string WarnOnInsertTheEmptyMindCube =>
         @"The Mind Cube, used to clairvoyance your personality, is <b>empty</b>.
Since clairvoyant is impossible in this state, please write your information in the Mind Writer in the previous room and try again.";

    /// <summary>ページ番号のテンプレート。</summary>
    public virtual string TemplatePages => "Pages: {0}/{1}";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public virtual string TemplateYourTypeIs =>
        "Your type is“<b>{0}</b>”!";

    /// <summary>説明サイズ。</summary>
    public virtual int SizeDescription => 200;

    /// <summary>詳細サイズ。</summary>
    public virtual int SizeDetails => 200;

    /// <summary>見出しサイズ。</summary>
    public virtual int SizeHeading => 320;

    /// <summary>行サイズ。</summary>
    public virtual int SizeLine => 72;

    /// <summary>言語種別。</summary>
    public virtual TypeLanguage Type => TypeLanguage.English;
}
