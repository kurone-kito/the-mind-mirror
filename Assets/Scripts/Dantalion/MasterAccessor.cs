using System;

/// <summary>マスター データへのアクセサー。</summary>
public static class MasterAccessor
{
    /// <summary>
    /// 根底となる人生観タイプを決定するために使用する、係数を取得します。
    /// </summary>
    /// <param name="month">算出したい月。</param>
    /// <param name="dateCoefficient">日係数。</param>
    /// <returns>根底となる人生観タイプのための、係数。</returns>
    public static byte GetLifeBaseFactor(int month, int dateCoefficient)
    {
        int index = month - 1;
        byte[] value = MasterData.LifeBaseFactor()[index];
        byte[] threshold = MasterData.LifeBaseThresholds()[index];
        for (int i = 0; i < value.Length; i++)
        {
            if (threshold.Length <= i || dateCoefficient < threshold[i])
            {
                return value[i];
            }
        }
        return value[value.Length - 1];
    }

    /// <summary>指定した年月の月係数を取得します。</summary>
    /// <param name="value">算出したい年月情報。</param>
    /// <returns>月係数。</returns>
    public static sbyte GetMonthlyCoefficient(DateTime value)
    {
        return GetMonthlyCoefficient(value.Year, value.Month);
    }

    /// <summary>指定した年月の月係数を取得します。</summary>
    /// <param name="year">算出したい年。</param>
    /// <param name="month">算出したい月。</param>
    /// <returns>月係数。</returns>
    public static sbyte GetMonthlyCoefficient(int year, int month)
    {
        int index = GetMonthIndex(year, month);
        sbyte[] mc = MasterData.MonthlyCoefficients();
        return index < 0 || mc.Length <= index ? (sbyte)-1 : mc[index];
    }

    /// <summary>月インデックスを算出します。</summary>
    /// <remarks>
    /// 1873 年 2 月を 0 とみなし、そこからの月数をカウントして算出します。
    /// </remarks>
    /// <param name="year">算出したい年。</param>
    /// <param name="month">算出したい月。</param>
    /// <returns>インデックス。</returns>
    private static int GetMonthIndex(int year, int month)
    {
#pragma warning disable IDE0090
        DateTime since = new DateTime(1873, 2, 1);
#pragma warning restore IDE0090
        return ((year - since.Year) * 12) + month - since.Month;
    }
}
