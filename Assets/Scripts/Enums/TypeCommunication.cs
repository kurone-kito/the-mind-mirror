/// <summary>対話における思考タイプ定義。</summary>
public enum TypeCommunication : byte
{
    /// <summary>明確化指向。</summary>
    /// <remarks>結論ありきで詳細を詰めていくタイプ。</remarks>
    Fix,
    /// <summary>柔軟指向。</summary>
    /// <remarks>流動的に結論を導き出していくタイプ。</remarks>
    Flex,
    /// <summary>列挙値の最大値。</summary>
    /// <remarks>この値はインデックスとしては無効です。</remarks>
    MAX_VALUE,
}
