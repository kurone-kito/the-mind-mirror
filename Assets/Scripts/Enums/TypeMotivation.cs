/// <summary>モチベーションが出やすい環境タイプ定義。</summary>
public enum TypeMotivation : byte
{
    /// <summary>他人と比べられるような環境。</summary>
    Competition,
    /// <summary>自主計画に沿って動ける環境。</summary>
    OwnMind,
    /// <summary>思い立ったが吉日、で動ける環境。</summary>
    Power,
    /// <summary>さらなる安泰を追求できる環境。</summary>
    Safety,
    /// <summary>日々の向上が自覚できる環境。</summary>
    SkillUp,
    /// <summary>周囲と異なることができる環境。</summary>
    Status,
    /// <summary>列挙値の最大値。</summary>
    /// <remarks>この値はインデックスとしては無効です。</remarks>
    MAX_VALUE,
}
