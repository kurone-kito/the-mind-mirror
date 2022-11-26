/// <summary>リスク管理のタイプ定義。</summary>
public enum TypeManagement : byte
{
    /// <summary>リスク重視。</summary>
    /// <remarks>リスク・リターンともに小さくなりがちなタイプ。</remarks>
    Care,
    /// <summary>リターン重視。</summary>
    /// <summary>リスク・リターンともに大きくなりがちなタイプ。</summary>
    Hope,
}
