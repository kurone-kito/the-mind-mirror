/// <summary>リスク管理のタイプ定義。</summary>
public enum TypeManagement : int
{
    /// <summary>リスク重視。</summary>
    /// <remarks>リスク・リターンともに小さくなりがちなタイプ。</remarks>
    Care,
    /// <summary>リターン重視。</summary>
    /// <summary>リスク・リターンともに大きくなりがちなタイプ。</summary>
    Hope,
    /// <summary>列挙値の最大値。</summary>
    /// <remarks>この値はインデックスとしては無効です。</remarks>
    MAX_VALUE,
}
