using UdonSharp;

/// <summary>フォールバック言語用テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class FallbackResources : UdonSharpBehaviour
{
    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public virtual string ComingSoon =>
         "We'll be adding more clairvoyant results in the future!";

    /// <summary>性格の大分類の説明。</summary>
    public virtual string GeniusDescription =>
        $"There are three main types of humans personality: “{GeniusTypes[(int)TypeGenius.Authority]}”, “{GeniusTypes[(int)TypeGenius.Economically]}”, and “{GeniusTypes[(int)TypeGenius.Humanely]}”.";

    /// <summary>性格の大分類の見出し。</summary>
    public virtual string GeniusHeading =>
        "Major categories of personality";

    /// <summary>性格の大分類の種別ごとの見出し。</summary>
    public virtual string[] GeniusTypes =>
        new[]
        {
            "Focused on authority",
            "Focused on economically",
            "Focused on humanely",
        };

    /// <summary>性格の大分類の種別ごとの説明。</summary>
    public virtual string[][] GeniusTypesDescriptions =>
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
    public virtual int SizeHeading => 400;

    /// <summary>行サイズ。</summary>
    public virtual int SizeLine => 72;

    /// <summary>小見出しサイズ。</summary>
    public virtual int SizeSubHeading => 320;

    /// <summary>言語種別。</summary>
    public virtual TypeLanguage Type => TypeLanguage.English;
}
