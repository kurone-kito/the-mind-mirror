using UdonSharp;

/// <summary>
/// ハードコーディングした、マスター データ群。
/// </summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MasterData : UdonSharpBehaviour
{
    /// <summary>仕事などの共同活動における、相性マップ。</summary>
    public static byte[][] Biz()
    {
        return new byte[][]
        {
#region Biz
            new byte[] {1, 2, 3, 2, 0, 1, 3, 2, 0, 2, 1, 2},
            new byte[] {1, 3, 2, 0, 2, 2, 1, 0, 1, 3, 2, 1},
            new byte[] {0, 0, 3, 2, 1, 2, 2, 0, 3, 1, 0, 2},
            new byte[] {3, 2, 3, 1, 2, 3, 1, 1, 3, 0, 1, 1},
            new byte[] {0, 2, 2, 3, 3, 0, 2, 0, 1, 0, 0, 0},
            new byte[] {2, 0, 0, 0, 3, 2, 0, 3, 3, 0, 2, 0},
            new byte[] {0, 0, 1, 0, 3, 0, 2, 0, 0, 1, 2, 3},
            new byte[] {0, 2, 0, 2, 1, 2, 1, 3, 2, 2, 0, 2},
            new byte[] {1, 1, 0, 3, 1, 3, 0, 1, 3, 2, 0, 0},
            new byte[] {3, 2, 0, 0, 0, 1, 0, 2, 2, 0, 2, 3},
            new byte[] {0, 1, 3, 1, 1, 2, 2, 1, 0, 0, 2, 0},
            new byte[] {2, 2, 1, 0, 0, 0, 3, 2, 2, 3, 3, 0},
#endregion
        };
    }

    /// <summary>性格情報における、詳細マップ。</summary>
    public static byte[][] DetailsMap()
    {
        return new byte[][]
        {
#region DetailsMap
            new byte[] { 1, 1, 1, 1, 5, 1, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1 },
            new byte[] { 0, 1, 0, 3, 4, 0, 2 },
            new byte[] { 1, 0, 0, 0, 2, 1, 0 },
            new byte[] { 0, 0, 0, 0, 4, 1, 2 },
            new byte[] { 1, 0, 1, 2, 5, 0, 0 },
            new byte[] { 1, 1, 1, 1, 3, 1, 2 },
            new byte[] { 0, 0, 0, 0, 0, 1, 1 },
            new byte[] { 0, 0, 1, 2, 1, 0, 1 },
            new byte[] { 1, 0, 1, 2, 3, 0, 2 },
            new byte[] { 1, 1, 0, 3, 2, 0, 0 },
            new byte[] { 0, 1, 0, 3, 0, 0, 1 },
#endregion
        };
    }

    /// <summary>基本素質タイプを決定するための、係数リスト。</summary>
    public static byte[][] Genius()
    {
        return new byte[][]
        {
#region Genius
            new byte[] { 5, 2, 10, 11, 6, 1, 0, 4, 3, 7, 9, 8 },
            new byte[] { 10, 2, 5, 8, 9, 7, 3, 4, 0, 1, 6, 11 },
            new byte[] { 7, 9, 8, 5, 2, 10, 11, 6, 1, 0, 4, 3 },
            new byte[] { 1, 6, 11, 10, 2, 5, 8, 9, 7, 3, 4, 0 },
            new byte[] { 0, 4, 3, 7, 9, 8, 5, 2, 10, 11, 6, 1 },
            new byte[] { 1, 6, 11, 10, 2, 5, 8, 9, 7, 3, 4, 0 },
            new byte[] { 0, 4, 3, 7, 9, 8, 5, 2, 10, 11, 6, 1 },
            new byte[] { 3, 4, 0, 1, 6, 11, 10, 2, 5, 8, 9, 7 },
            new byte[] { 11, 6, 1, 0, 4, 3, 7, 9, 8, 5, 2, 10 },
            new byte[] { 8, 9, 7, 3, 4, 0, 1, 6, 11, 10, 2, 5 },
#endregion
        };
    }

    /// <summary>
    /// 根底となる人生観タイプを決定するための、係数リスト。
    /// </summary>
    public static byte[][] LifeBase()
    {
        return new byte[][]
        {
#region LifeBase
            new byte[] { 2, 3, 5, 4, 6, 1, 7, 0, 8, 9 },
            new byte[] { 9, 8, 3, 2, 4, 5, 1, 6, 0, 7 },
            new byte[] { 8, 9, 2, 3, 5, 4, 6, 1, 7, 0 },
            new byte[] { 0, 7, 9, 8, 3, 2, 4, 5, 1, 6 },
            new byte[] { 7, 0, 8, 9, 2, 3, 5, 4, 6, 1 },
            new byte[] { 1, 6, 0, 7, 9, 8, 3, 2, 4, 5 },
            new byte[] { 6, 1, 7, 0, 8, 9, 2, 3, 5, 4 },
            new byte[] { 4, 5, 1, 6, 0, 7, 9, 8, 3, 2 },
            new byte[] { 5, 4, 6, 1, 7, 0, 8, 9, 2, 3 },
            new byte[] { 3, 2, 4, 5, 1, 6, 0, 7, 9, 8 },
#endregion
        };
    }

    /// <summary>
    /// 根底となる人生観タイプを決定するための、係数リスト。
    /// </summary>
    public static byte[][] LifeBaseFactor()
    {
        return new byte[][]
        {
#region LifeBaseCoefficients
            new byte[] { 10, 8, 6 },
            new byte[] { 6, 5, 3, 1 },
            new byte[] { 1, 2 },
            new byte[] { 2, 10, 5 },
            new byte[] { 5, 7, 3 },
            new byte[] { 3, 4 },
            new byte[] { 4, 2, 6 },
            new byte[] { 6, 5, 9, 7 },
            new byte[] { 7, 8 },
            new byte[] { 8, 4, 5 },
            new byte[] { 8, 4, 5 },
#pragma warning disable IDE0230
            new byte[] { 9, 10 },
#pragma warning disable IDE0230
#endregion
        };
    }

    /// <summary>
    /// 根底となる人生観タイプを決定するための、係数リスト。
    /// </summary>
    public static byte[][] LifeBaseThresholds()
    {
        return new byte[][]
        {
#region LifeBaseThresholds
            new byte[] { 9, 13 },
            new byte[] { 0, 5, 14 },
            new byte[] { 10 },
            new byte[] { 9, 13 },
            new byte[] { 5, 14 },
            new byte[] { 10 },
            new byte[] { 9, 13 },
            new byte[] { 3, 5, 14 },
            new byte[] { 10 },
            new byte[] { 9, 13 },
            new byte[] { 5, 14 },
            new byte[] { 10 },
#endregion
        };
    }

    /// <summary>恋愛・友人などの交際関係における、相性マップ。</summary>
    public static byte[][] Love()
    {
        return new byte[][]
        {
#region Love
            new byte[] { 3, 1, 0, 2, 2, 1, 1, 1, 0, 3, 2, 0 },
            new byte[] { 0, 0, 1, 1, 3, 0, 0, 3, 1, 3, 3, 2 },
            new byte[] { 2, 2, 2, 2, 2, 3, 2, 0, 0, 0, 0, 3 },
            new byte[] { 2, 1, 3, 0, 1, 3, 1, 0, 1, 0, 3, 1 },
            new byte[] { 0, 3, 0, 3, 2, 0, 2, 0, 2, 3, 0, 0 },
            new byte[] { 2, 3, 3, 2, 0, 2, 0, 3, 3, 1, 1, 2 },
            new byte[] { 0, 1, 0, 0, 3, 3, 3, 0, 0, 2, 3, 0 },
            new byte[] { 3, 2, 1, 3, 2, 0, 3, 2, 3, 1, 0, 0 },
            new byte[] { 1, 0, 2, 0, 3, 3, 1, 2, 2, 3, 2, 0 },
            new byte[] { 1, 2, 0, 1, 0, 1, 1, 3, 3, 2, 1, 1 },
            new byte[] { 1, 0, 0, 3, 0, 1, 3, 0, 0, 2, 0, 1 },
            new byte[] { 2, 1, 3, 0, 1, 0, 2, 2, 0, 1, 1, 3 },
#endregion
        };
    }

    /// <summary>
    /// 行動を起こす際の、潜在能力タイプを決定するための、係数リスト。
    /// </summary>
    public static byte[][] Potential()
    {
        return new byte[][]
        {
#region Potential
            new byte[] { 2, 3, 4, 5, 8, 9, 0, 1, 6, 7 },
            new byte[] { 7, 6, 3, 2, 5, 4, 9, 8, 1, 0 },
            new byte[] { 6, 7, 2, 3, 4, 5, 8, 9, 0, 1 },
            new byte[] { 1, 0, 7, 6, 3, 2, 5, 4, 9, 8 },
            new byte[] { 0, 1, 6, 7, 2, 3, 4, 5, 8, 9 },
            new byte[] { 9, 8, 1, 0, 7, 6, 3, 2, 5, 4 },
            new byte[] { 8, 9, 0, 1, 6, 7, 2, 3, 4, 5 },
            new byte[] { 5, 4, 9, 8, 1, 0, 7, 6, 3, 2 },
            new byte[] { 4, 5, 8, 9, 0, 1, 6, 7, 2, 3 },
            new byte[] { 3, 2, 5, 4, 9, 8, 1, 0, 7, 6 },
#endregion
        };
    }

    /// <summary>月ごとの性格タイプ判定係数。</summary>
    /// <remarks>
    /// インデックスが 1873 年 2 月からの経過月数に対応し、
    /// 1873 年 2 月 ～ 2050 年 12 月までのデータを格納しています。
    /// </remarks>
    public static sbyte[] MonthlyCoefficients()
    {
        return new sbyte[]
        {
#region MonthlyCoefficients
            4, 6, 5, 6, 6, 7, 8, 8, 8, 8, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9,
            8, 4, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 8, 6, 5, 5, 5, 5, 6, 7,
            8, 7, 8, 7, 7, 5, 4, 6, 5, 6, 6, 7, 8, 8, 8, 8, 7, 6, 4, 6, 5,
            6, 6, 8, 8, 8, 9, 8, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 8, 6,
            5, 5, 5, 5, 6, 7, 8, 8, 8, 7, 7, 5, 4, 6, 5, 6, 6, 7, 8, 8, 8,
            8, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 4, 6, 5, 6, 6, 7,
            8, 8, 9, 8, 8, 6, 5, 5, 5, 5, 6, 7, 7, 8, 8, 7, 7, 6, 4, 6, 5,
            6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6,
            4, 6, 5, 6, 8, 8, 8, 9, 9, 8, 8, 6, 5, 5, 5, 5, 6, 7, 7, 7, 8,
            7, 7, 5, 4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7,
            8, 8, 9, 8, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 8, 6, 5, 5, 5,
            5, 6, 7, 7, 7, 8, 7, 7, 5, 4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6,
            4, 6, 5, 6, 6, 7, 8, 8, 9, 8, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9,
            8, 8, 6, 5, 5, 5, 5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 6, 5, 6, 6, 7,
            8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7, 8, 8, 9, 8, 7, 6, 4, 6, 5,
            6, 6, 8, 8, 8, 9, 8, 8, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 8, 6,
            5, 7, 6, 6, 7, 8, 9, 9, 9, 8, 8, 6, 5, 7, 6, 7, 7, 8, 9, 9, 9,
            8, 8, 7, 5, 7, 6, 7, 7, 9, 9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 8,
            8, 8, 9, 8, 7, 6, 5, 6, 5, 6, 7, 8, 8, 9, 9, 8, 8, 6, 5, 7, 6,
            7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 7, 6, 7, 7, 9, 9, 9, 9, 8, 8, 7,
            5, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 6, 6, 7, 8, 8, 9, 9,
            8, 8, 6, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 7, 6, 7, 7, 9,
            9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 6,
            6, 7, 8, 8, 9, 9, 8, 8, 6, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7,
            5, 7, 6, 7, 7, 9, 9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 8, 8, 8, 9,
            8, 7, 6, 5, 6, 6, 6, 7, 8, 8, 8, 9, 8, 8, 6, 5, 6, 6, 6, 7, 8,
            8, 9, 9, 8, 8, 7, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 6, 5,
            6, 6, 8, 8, 8, 8, 8, 7, 6, 5, 6, 5, 6, 7, 8, 8, 8, 9, 8, 8, 6,
            5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 7, 6, 7, 7, 8, 9, 9, 9,
            8, 8, 7, 5, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6, 5, 6, 6, 6, 6, 8,
            8, 8, 9, 8, 7, 6, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 7, 6,
            7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6,
            5, 6, 6, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 7, 6, 7, 6, 8, 9, 9, 9,
            8, 8, 7, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 8,
            8, 8, 8, 7, 7, 6, 5, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 7, 6,
            6, 7, 8, 9, 9, 9, 8, 8, 7, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7,
            5, 6, 5, 6, 6, 8, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9,
            8, 7, 6, 5, 6, 6, 6, 7, 8, 8, 9, 9, 8, 8, 6, 5, 7, 6, 7, 7, 8,
            9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 8, 8, 8, 8, 7, 7, 6, 4, 6, 5,
            6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 6, 6, 7, 8, 8, 9, 9, 8, 8, 6,
            5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 8, 8, 8, 8,
            7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 6, 6, 7, 8,
            8, 9, 9, 8, 8, 6, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 6, 5,
            6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6,
            5, 6, 6, 6, 7, 6, 8, 8, 9, 8, 8, 6, 5, 7, 6, 7, 7, 8, 9, 9, 9,
            8, 8, 7, 5, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8,
            8, 8, 8, 8, 7, 6, 5, 6, 6, 6, 6, 8, 8, 8, 9, 8, 8, 6, 5, 7, 6,
            7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6,
            4, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6, 5, 6, 6, 6, 6, 8, 8, 8, 9,
            8, 7, 6, 5, 7, 6, 7, 7, 8, 9, 9, 9, 8, 8, 7, 5, 6, 5, 6, 6, 7,
            8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6, 5, 6, 6,
            6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 6, 6, 7, 8, 9, 9, 9, 8, 8, 7,
            5, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8,
            8, 7, 6, 5, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 7, 6, 6, 7, 8,
            8, 9, 9, 8, 8, 7, 5, 8, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5,
            6, 6, 8, 8, 8, 9, 8, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6,
            5, 6, 6, 6, 7, 8, 8, 9, 9, 8, 8, 6, 5, 6, 5, 6, 6, 7, 8, 8, 8,
            7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8,
            8, 8, 9, 8, 7, 6, 5, 6, 6, 6, 7, 8, 8, 9, 9, 8, 8, 6, 5, 6, 5,
            6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6,
            4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 6, 6, 7, 8, 8, 8, 9,
            8, 8, 6, 5, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7,
            8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 6,
            6, 7, 8, 8, 8, 9, 8, 8, 6, 5, 5, 5, 5, 6, 7, 8, 8, 8, 7, 7, 6,
            4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8,
            8, 7, 6, 5, 6, 6, 6, 6, 8, 8, 8, 9, 8, 8, 6, 5, 6, 5, 6, 6, 7,
            8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5,
            6, 6, 8, 8, 8, 8, 8, 7, 6, 5, 6, 6, 6, 6, 8, 8, 8, 9, 8, 7, 6,
            5, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7, 8, 8, 8,
            7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6, 5, 6, 6, 6, 6, 8,
            8, 8, 9, 8, 7, 6, 5, 6, 5, 5, 6, 7, 7, 8, 8, 7, 7, 5, 4, 5, 5,
            6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6,
            5, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 6, 5, 5, 6, 7, 7, 8, 8,
            7, 7, 6, 4, 5, 5, 6, 6, 7, 7, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8,
            8, 8, 8, 7, 7, 6, 5, 6, 5, 6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 5, 5,
            5, 6, 7, 7, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6,
            4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 9,
            8, 7, 6, 5, 5, 5, 5, 6, 7, 7, 8, 8, 7, 7, 5, 4, 6, 5, 5, 6, 7,
            8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5,
            6, 6, 8, 8, 8, 9, 8, 7, 6, 5, 5, 5, 5, 6, 7, 7, 7, 8, 7, 7, 5,
            4, 6, 5, 5, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7, 8, 8, 8,
            7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6, 5, 5, 5, 5, 5, 7,
            7, 7, 8, 7, 7, 5, 4, 6, 5, 6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5,
            6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 8, 8, 8, 8, 8, 7, 6,
            5, 5, 5, 5, 5, 7, 7, 7, 8, 7, 7, 5, 3, 5, 4, 5, 5, 7, 7, 7, 8,
            7, 7, 5, 4, 5, 5, 5, 6, 7, 7, 8, 8, 7, 7, 6, 4, 6, 5, 6, 6, 7,
            8, 8, 8, 8, 7, 6, 4, 5, 4, 5, 5, 6, 7, 7, 8, 7, 7, 5, 3, 5, 4,
            5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 5, 5, 5, 6, 7, 7, 7, 8, 7, 7, 5,
            4, 6, 5, 6, 6, 7, 8, 8, 8, 8, 7, 6, 4, 5, 4, 5, 5, 6, 7, 7, 8,
            7, 6, 5, 3, 5, 4, 5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 5, 5, 5, 5, 7,
            7, 7, 8, 7, 7, 5, 4, 6, 5, 6, 6, 7, 8, 8, 8, 8, 7, 6, 4, 5, 4,
            5, 5, 6, 7, 7, 8, 7, 6, 5, 3, 5, 4, 5, 5, 7, 7, 7, 8, 7, 7, 5,
            4, 5, 5, 5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 6, 5, 6, 6, 7, 8, 8, 8,
            7, 7, 6, 4, 5, 4, 5, 5, 6, 7, 7, 8, 7, 6, 5, 3, 5, 4, 5, 5, 7,
            7, 7, 8, 7, 7, 5, 4, 5, 5, 5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 6, 5,
            6, 6, 7, 8, 8, 8, 7, 7, 6, 4, 5, 4, 5, 5, 6, 7, 7, 8, 7, 6, 5,
            3, 5, 4, 5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 5, 5, 5, 5, 7, 7, 7, 8,
            7, 7, 5, 4, 6, 5, 5, 6, 7, 7, 8, 8, 7, 7, 6, 4, 5, 4, 5, 5, 6,
            7, 7, 8, 7, 6, 5, 3, 5, 4, 5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 5, 4,
            5, 5, 7, 7, 7, 8, 7, 7, 5, 4, 6, 5, 5, 6, 7, 7, 8, 8, 7, 7, 6,
            4, 5, 4, 5, 5, 6, 7, 7, 7, 7, 6, 5, 3, 5, 4, 5, 5, 7, 7, 7, 8,
            7, 7, 5, 4, 5, 4, 5, 5, 7, 7, 7, 8, 7, 7
#endregion
        };
    }
}