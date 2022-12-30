/// <summary>行動を起こす際の、潜在能力タイプ定義。</summary>
public enum TypePotential : int
{
    /// <summary>分析・応用力に優れ、一つのものを追求する能力。</summary>
    Ci,
    /// <summary>新しいもの、0 から 1 を生む能力。</summary>
    Co,
    /// <summary>アーティストのような、非言語的な表現能力。</summary>
    Ei,
    /// <summary>能動的な、言葉による表現能力。</summary>
    Eo,
    /// <summary>数字の裏に隠れた意味や傾向を見抜く能力。</summary>
    Fi,
    /// <summary>数字やデータで物事を表現できる能力。</summary>
    Fo,
    /// <summary>聞き上手で、相手の本音を聞き出せる能力。</summary>
    Ii,
    /// <summary>話を聞くより伝えたい、押しの強いトーク能力。</summary>
    Io,
    /// <summary>集団・組織を維持したり、内向きに強固にする能力。</summary>
    Ni,
    /// <summary>集団・組織を外向きに拡大・発展させる能力。</summary>
    No,
    /// <summary>列挙値の最大値。</summary>
    /// <remarks>この値はインデックスとしては無効です。</remarks>
    MAX_VALUE,
}
