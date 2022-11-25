using UdonSharp;

/// <summary>
/// テキスト リソース データ群。
/// </summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class Resources : UdonSharpBehaviour
{
    /// <summary>思考タイプ一覧。</summary>
    public static string[] Brain()
    {
        return new string[] { "Left", "Right" };
    }

    /// <summary>対話における思考タイプ一覧。</summary>
    public static string[] Communication()
    {
        return new string[] { "Fix", "Flex" };
    }

    /// <summary>詳細な素質タイプ一覧。</summary>
    public static string[] DetailedGenius()
    {
        return new string[] {
            "A000", "E001", "H012", "A024", "H025", "A100",
            "H108", "E125", "E555", "H789", "A888", "E919"
        };
    }

    /// <summary>大まかな素質タイプ一覧。</summary>
    public static string[] GeneralGenius()
    {
        return new string[] { "Authority", "Economically", "Humanely" };
    }

    /// <summary>人生観タイプ一覧。</summary>
    public static string[] Lifebase()
    {
        return new string[] {
            "Application", "Association", "Development",
            "Expression", "Finance", "Investment",
            "Organization", "Quest", "SelfMind", "SelfReliance"
        };
    }

    /// <summary>リスク管理タイプ一覧。</summary>
    public static string[] Management()
    {
        return new string[] { "Care", "Hope" };
    }

    /// <summary>モチベーションタイプ一覧。</summary>
    public static string[] Motivation()
    {
        return new string[] {
            "Competition", "OwnMind", "Power",
            "Safety", "SkillUp", "Status"
        };
    }

    /// <summary>立ち位置タイプ一覧。</summary>
    public static string[] Position()
    {
        return new string[] { "Adjust", "Brain", "Direct", "Quick" };
    }

    /// <summary>潜在能力タイプ一覧。</summary>
    public static string[] Potential()
    {
        return new string[] {
            "Ci", "Co", "Ei", "Eo", "Fi", "Fo", "Ii", "Io", "Ni", "No"
        };
    }

    /// <summary>立ち位置タイプ一覧。</summary>
    public static string[] Response()
    {
        return new string[] { "Action", "Mind" };
    }
}
