/// <summary>素質を持つ、立ち位置タイプ定義。</summary>
public enum TypeResponse : int
{
    /// <summary>現場タイプ。</summary>
    /// <remark>知らない人々の中でも、比較的活動できるタイプ。</remark>
    Action,
    /// <summary>裏方タイプ。</summary>
    /// <remark>周囲を常に仲間で固めた方が、良く動けるタイプ。</remark>
    Mind,
    /// <summary>列挙値の最大値。</summary>
    /// <remarks>この値はインデックスとしては無効です。</remarks>
    MAX_VALUE,
}
