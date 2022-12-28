using System;

using MD = MasterData;
using PPP = PersonalityParamsPacker;

/// <summary>日付情報のインデックス。</summary>
internal enum BDIndex : int
{
    /// <summary>日付。</summary>
    Date,
    /// <summary>月が 1 月もしくは 2 月であるかどうか。</summary>
    EarlyMonth,
    /// <summary>月。</summary>
    Month,
    /// <summary>1・2 月を 13・14 月としてシフトした値。</summary>
    ShiftedMonth,
    /// <summary>年。</summary>
    Year,
    /// <summary>年の上 2 桁。</summary>
    HiYear,
    /// <summary>年の下 2 桁。</summary>
    LoYear,
    /// <summary>配列の最大値。</summary>
    /// <remarks>この値はインデックスとしては無効です。</remarks>
    MAX_VALUE,
}

/// <summary>性格情報のインデックス。</summary>
internal enum PSIndex : int
{
    /// <summary>補助的な素質の変化。</summary>
    Cycle,
    /// <summary>内面的な素質。</summary>
    Inner,
    /// <summary>根底となる人生観。</summary>
    LifeBase,
    /// <summary>外面的な素質。</summary>
    Outer,
    /// <summary>行動を起こす際における、潜在能力 A。</summary>
    PotentialA,
    /// <summary>行動を起こす際における、潜在能力 B。</summary>
    PotentialB,
    /// <summary>緊急時・集中時の素質。</summary>
    WorkStyle,
    /// <summary>配列の最大値。</summary>
    /// <remarks>この値はインデックスとしては無効です。</remarks>
    MAX_VALUE,
}

/// <summary>Dantalion エンジンのコア ロジック。</summary>
/// <seealso cref="https://kurone-kito.github.io/dantalion/"/>
public static class Dantalion
{
    /// <summary>性格情報を取得します。</summary>
    /// <param name="birth">生年月日。</param>
    /// <returns>性格情報。</returns>
    public static uint GetPersonality(this DateTime birth)
    {
        byte[] unpacked = birth.GetUnpackedPersonality();
        if (unpacked == null)
        {
            return uint.MaxValue;
        }
        int cycleIndex = (int)PSIndex.Cycle;
        int lbIndex = (int)PSIndex.LifeBase;
        int innerIndex = (int)PSIndex.Inner;
        int outerIndex = (int)PSIndex.Outer;
        int paIndex = (int)PSIndex.PotentialA;
        int pbIndex = (int)PSIndex.PotentialB;
        int wsIndex = (int)PSIndex.WorkStyle;
        uint result = 0u;
        result = PPP.PackCycle(result, unpacked[cycleIndex]);
        result = PPP.PackLifeBase(result, unpacked[lbIndex]);
        result = PPP.PackInner(result, unpacked[innerIndex]);
        result = PPP.PackOuter(result, unpacked[outerIndex]);
        result = PPP.PackPotentialA(result, unpacked[paIndex]);
        result = PPP.PackPotentialB(result, unpacked[pbIndex]);
        return PPP.PackWorkStyle(result, unpacked[wsIndex]);
    }

    /// <summary>性格情報を取得します。</summary>
    /// <param name="birth">生年月日。</param>
    /// <returns>性格情報。</returns>
    private static byte[] GetUnpackedPersonality(this DateTime birth)
    {
        sbyte monthlyCoefficient =
            MasterAccessor.GetMonthlyCoefficient(birth);
        if (monthlyCoefficient < 0)
        {
            return null;
        }
        int[] birthDetails = birth.GetDateDetails();
        int[] factors = GetFactors(birthDetails, monthlyCoefficient);
        int cycleIndex = (int)PSIndex.Cycle;
        int lbIndex = (int)PSIndex.LifeBase;
        int innerIndex = (int)PSIndex.Inner;
        int outerIndex = (int)PSIndex.Outer;
        int paIndex = (int)PSIndex.PotentialA;
        int pbIndex = (int)PSIndex.PotentialB;
        int wsIndex = (int)PSIndex.WorkStyle;
        byte LifeBase = MasterAccessor.GetLifeBaseFactor(
            birthDetails[(int)BDIndex.Month], factors[lbIndex]);
        int cycle = factors[cycleIndex];
        int y = cycle % 10;
        byte[] ps = new byte[factors.Length];
        byte[][] geniusTable = MD.Genius();
        byte[][] potentialTable = MD.Potential();
        ps[cycleIndex] = (byte)(Math.Abs(cycle) & byte.MaxValue);
        ps[innerIndex] = geniusTable[y][factors[innerIndex] - 1];
        ps[lbIndex] = MD.LifeBase()[y][LifeBase - 1];
        ps[outerIndex] = geniusTable[y][factors[outerIndex] - 1];
        ps[paIndex] = potentialTable[y][factors[paIndex] - 1];
        ps[pbIndex] = potentialTable[y][factors[pbIndex] - 1];
        ps[wsIndex] = geniusTable[y][factors[wsIndex] - 1];
        return ps;
    }

    /// <summary>日付の詳細情報を取得します。</summary>
    /// <param name="birth">日付情報。</param>
    /// <returns>日付の詳細情報。</returns>
    /// <seealso cref="BDIndex"/>
    private static int[] GetDateDetails(this DateTime birth)
    {
        int[] details = new int[(int)BDIndex.MAX_VALUE];
        details[(int)BDIndex.Date] = birth.Day;
        details[(int)BDIndex.EarlyMonth] = birth.Month <= 2 ? 1 : 0;
        details[(int)BDIndex.Month] = birth.Month;
        details[(int)BDIndex.ShiftedMonth] = birth.Month + (12 * details[(int)BDIndex.EarlyMonth]);
        details[(int)BDIndex.Year] = birth.Year;
        details[(int)BDIndex.HiYear] = birth.Year / 100;
        details[(int)BDIndex.LoYear] = birth.Year % 100;
        return details;
    }

    /// <summary>
    /// 性格決定のための、要因情報を取得します。
    /// </summary>
    /// <param name="dateDetails">日付情報。</param>
    /// <param name="monthlyCoefficient">月係数。</param>
    /// <returns>性格決定のための、要因情報。</returns>
    /// <seealso cref="PSIndex"/>
    private static int[] GetFactors(int[] dateDetails, sbyte monthlyCoefficient)
    {
        int date = dateDetails[(int)BDIndex.Date];
        int earlyMonth = dateDetails[(int)BDIndex.EarlyMonth];
        int month = dateDetails[(int)BDIndex.Month];
        int shiftedMonth = dateDetails[(int)BDIndex.ShiftedMonth];
        int year = dateDetails[(int)BDIndex.Year];
        int hiYear = dateDetails[(int)BDIndex.HiYear];
        int loYear = dateDetails[(int)BDIndex.LoYear];
        bool lessThan = date < monthlyCoefficient;
        int outer = ShiftModulo(month - (lessThan ? 1 : 0), 12) + 1;
        int workStyle = year + 9 -
            (lessThan ? earlyMonth : month == 1 ? 1 : 0);
        int cycle =
            (int)(hiYear * 4.25f) + (int)((shiftedMonth + 1) * 0.6f) +
            (int)((loYear - earlyMonth) * 5.25f) + date + 7;
        int potentialA = ShiftModulo(workStyle - 2, 10);
        int potentialB = ShiftModulo((year * 2) + outer + 2, 10);
        int[] factors = new int[(int)PSIndex.MAX_VALUE];
        factors[(int)PSIndex.Cycle] = ShiftModulo(cycle, 10);
        factors[(int)PSIndex.Inner] =
            ShiftModulo((shiftedMonth * 6) + (hiYear * 4) + cycle - 6, 12);
        factors[(int)PSIndex.LifeBase] = date - monthlyCoefficient;
        factors[(int)PSIndex.Outer] = ShiftModulo(outer, 12);
        factors[(int)PSIndex.PotentialA] = potentialA;
        factors[(int)PSIndex.PotentialB] = potentialB;
        factors[(int)PSIndex.WorkStyle] =
            ShiftModulo(workStyle, 12);
        return factors;
    }

    /// <summary>
    /// あまりは常に正の値になるように、シフトします。
    /// </summary>
    /// <param name="a">対象の値。</param>
    /// <param name="n">除算する値。</param>
    /// <returns>計算結果。</returns>
    private static int ShiftModulo(int a, int n)
    {
        return ((((a - 1) % n) + n) % n) + 1;
    }
}
