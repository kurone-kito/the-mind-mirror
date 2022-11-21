using UdonSharp;

/// <summary>性格情報のビットシフト定数。</summary>
internal enum BitShifts
{
    /// <summary>内面的な素質。</summary>
    Inner = 0,
    /// <summary>外面的な素質。</summary>
    Outer = 4,
    /// <summary>緊急時・集中時の素質。</summary>
    WorkStyle = 8,
    /// <summary>サイクル。</summary>
    Cycle = 12,
    /// <summary>ライフベース。</summary>
    LifeBase = 16,
    /// <summary>ポテンシャル A。</summary>
    PotentialA = 20,
    /// <summary>ポテンシャル B。</summary>
    PotentialB = 24,
}

/// <summary>
/// 圧縮された性格情報にアクセス、値を取得・設定するクラス。
/// </summary>
/// <remarks>
/// <list type="table">
/// <listheader>
/// <term>性格情報</term>
/// <term>ビット幅</term>
/// <term>ビットシフト</term>
/// </listheader>
/// <item>
/// <term>内面的な素質</term>
/// <term>4</term>
/// <term>0</term>
/// </item>
/// <item>
/// <term>外面的な素質</term>
/// <term>4</term>
/// <term>4</term>
/// </item>
/// <item>
/// <term>緊急時・集中時の素質</term>
/// <term>4</term>
/// <term>8</term>
/// </item>
/// <item>
/// <term>サイクル</term>
/// <term>4</term>
/// <term>12</term>
/// </item>
/// <item>
/// <term>ライフベース</term>
/// <term>4</term>
/// <term>16</term>
/// </item>
/// <item>
/// <term>ポテンシャル A</term>
/// <term>4</term>
/// <term>20</term>
/// </item>
/// <item>
/// <term>ポテンシャル B</term>
/// <term>4</term>
/// <term>24</term>
/// </item>
/// </list>
/// </remarks>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class PersonalityParamsPacker : UdonSharpBehaviour
{
    /// <summary>各性格パラメーターのビット幅。</summary>
    /// <remarks>4 ビット、つまり 0 ～ 15 の値を扱えます。</remarks>
    private const int BIT_WIDTH = 4;

    /// <summary>内面的な素質をバイナリに設定します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>設定されたバイナリ本体。</returns>
    public static uint PackInner(uint body, byte value)
    {
        uint InnerMask = CreateMask(BitShifts.Inner);
        return Pack(InnerMask, BitShifts.Inner, body, value);
    }

    /// <summary>バイナリから内面的な素質を取得します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <returns>内面的な素質。</returns>
    public static byte UnPackInner(uint body)
    {
        uint InnerMask = CreateMask(BitShifts.Inner);
        return UnPack(body, InnerMask, BitShifts.Inner);
    }

    /// <summary>外面的な素質をバイナリに設定します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>設定されたバイナリ本体。</returns>
    public static uint PackOuter(uint body, byte value)
    {
        uint OuterMask = CreateMask(BitShifts.Outer);
        return Pack(OuterMask, BitShifts.Outer, body, value);
    }

    /// <summary>バイナリから外面的な素質を取得します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <returns>外面的な素質。</returns>
    public static byte UnPackOuter(uint body)
    {
        uint OuterMask = CreateMask(BitShifts.Outer);
        return UnPack(body, OuterMask, BitShifts.Outer);
    }

    /// <summary>緊急時・集中時の素質をバイナリに設定します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>設定されたバイナリ本体。</returns>
    public static uint PackWorkStyle(uint body, byte value)
    {
        uint WorkStyleMask = CreateMask(BitShifts.WorkStyle);
        return Pack(WorkStyleMask, BitShifts.WorkStyle, body, value);
    }

    /// <summary>バイナリから緊急時・集中時の素質を取得します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <returns>緊急時・集中時の素質。</returns>
    public static byte UnPackWorkStyle(uint body)
    {
        uint WorkStyleMask = CreateMask(BitShifts.WorkStyle);
        return UnPack(body, WorkStyleMask, BitShifts.WorkStyle);
    }

    /// <summary>サイクルをバイナリに設定します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>設定されたバイナリ本体。</returns>
    public static uint PackCycle(uint body, byte value)
    {
        uint CycleMask = CreateMask(BitShifts.Cycle);
        return Pack(CycleMask, BitShifts.Cycle, body, value);
    }

    /// <summary>バイナリからサイクルを取得します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <returns>サイクル。</returns>
    public static byte UnPackCycle(uint body)
    {
        uint CycleMask = CreateMask(BitShifts.Cycle);
        return UnPack(body, CycleMask, BitShifts.Cycle);
    }

    /// <summary>ライフベースをバイナリに設定します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>設定されたバイナリ本体。</returns>
    public static uint PackLifeBase(uint body, byte value)
    {
        uint LifeBaseMask = CreateMask(BitShifts.LifeBase);
        return Pack(LifeBaseMask, BitShifts.LifeBase, body, value);
    }

    /// <summary>バイナリからライフベースを取得します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <returns>ライフベース。</returns>
    public static byte UnPackLifeBase(uint body)
    {
        uint LifeBaseMask = CreateMask(BitShifts.LifeBase);
        return UnPack(body, LifeBaseMask, BitShifts.LifeBase);
    }

    /// <summary>ポテンシャル A をバイナリに設定します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>設定されたバイナリ本体。</returns>
    public static uint PackPotentialA(uint body, byte value)
    {
        uint PotentialAMask = CreateMask(BitShifts.PotentialA);
        return Pack(PotentialAMask, BitShifts.PotentialA, body, value);
    }

    /// <summary>バイナリからポテンシャル A を取得します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <returns>ポテンシャル A。</returns>
    public static byte UnPackPotentialA(uint body)
    {
        uint PotentialAMask = CreateMask(BitShifts.PotentialA);
        return UnPack(body, PotentialAMask, BitShifts.PotentialA);
    }

    /// <summary>ポテンシャル B をバイナリに設定します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>設定されたバイナリ本体。</returns>
    public static uint PackPotentialB(uint body, byte value)
    {
        uint PotentialBMask = CreateMask(BitShifts.PotentialB);
        return Pack(PotentialBMask, BitShifts.PotentialB, body, value);
    }

    /// <summary>バイナリからポテンシャル B を取得します。</summary>
    /// <param name="body">バイナリ本体。</param>
    /// <returns>ポテンシャル B。</returns>
    public static byte UnPackPotentialB(uint body)
    {
        uint PotentialBMask = CreateMask(BitShifts.PotentialB);
        return UnPack(body, PotentialBMask, BitShifts.PotentialB);
    }

    /// <summary>
    /// バイナリに新しい値を上書きし、新しいバイナリ値を取得します。
    /// </summary>
    /// <param name="mask">ビットマスク。</param>
    /// <param name="shift">ビットシフト量を示す定数。</param>
    /// <param name="body">バイナリ値。</param>
    /// <param name="value">0 ～ 15 の値。</param>
    /// <returns>新しいバイナリ値。</returns>
    private static uint Pack(uint mask, BitShifts shift, uint body, byte value)
    {
        return (body & ~mask) | ((uint)value << (int)shift);
    }

    /// <summary>
    /// バイナリから、指定したビットシフト位置における値を取得します。
    /// </summary>
    /// <param name="body">バイナリ本体。</param>
    /// <param name="mask">ビットマスク。</param>
    /// <param name="shift">ビットシフト量を示す定数。</param>
    /// <returns></returns>
    private static byte UnPack(uint body, uint mask, BitShifts shift)
    {
        return (byte)((body & mask) >> (int)shift);
    }

    /// <summary>ビットマスクを作成します。</summary>
    /// <param name="shift">ビットシフト量を示す定数。</param>
    /// <returns>ビットマスク。</returns>
    private static uint CreateMask(BitShifts shift)
    {
        int s = (int)shift;
        return (1U << (BIT_WIDTH + s)) - (1U << s);
    }
}
