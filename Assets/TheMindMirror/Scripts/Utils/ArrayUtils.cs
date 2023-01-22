using UnityEngine;

/// <summary>配列制御用の汎用関数群。</summary>
public static class ArrayUtils
{
    /// <summary>配列を連結します。</summary>
    /// <typeparam name="T">配列の要素の型。</typeparam>
    /// <param name="arrays">連結する配列。</param>
    /// <returns>連結された配列。</returns>
    public static T[] Flatten<T>(params T[][] arrays)
    {
        int totalLength = 0;
        foreach (T[] array in arrays)
        {
            totalLength += array.Length;
        }
        T[] flattened = new T[totalLength];
        int offset = 0;
        foreach (T[] array in arrays)
        {
            array.CopyTo(flattened, offset);
            offset += array.Length;
        }
        return flattened;
    }

    /// <summary>2つの配列を連結します。</summary>
    /// <typeparam name="T">配列の要素の型。</typeparam>
    /// <param name="array1">連結する配列。</param>
    /// <param name="array2">連結する配列。</param>
    /// <returns>連結した配列。</returns>
    public static T[] Join<T>(T[] array1, T[] array2)
    {
        T[] joined = new T[array1.Length + array2.Length];
        array1.CopyTo(joined, 0);
        array2.CopyTo(joined, array1.Length);
        return joined;
    }

    /// <summary>
    /// 配列の要素を、ログに出力します。
    /// </summary>
    /// <typeparam name="T">配列の要素の型。</typeparam>
    /// <param name="array">対象の配列。</param>
    public static void Log<T>(this T[] array)
    {
        string[] stringed = new string[array.Length];
        for (int i = array.Length; --i >= 0;)
        {
            stringed[i] = array[i].ToString();
        }
        Debug.Log(string.Join(", ", stringed));
    }

    /// <summary>
    /// フォーマット文字列と引数の配列をマッピングします。
    /// </summary>
    /// <param name="format">フォーマット文字列。</param>
    /// <param name="args">引数の配列。</param>
    /// <returns>マッピングされた文字列の配列。</returns>
    public static string[] MapWithFormat(
            // 可変長引数でジャグ配列を渡すと、UdonSharp のバグで最終要素しか
            // 渡らないため、new string[] { ... } でラップして渡す。
            this string format, string[][] args)
    {
        int argsLength = args.Length;
        int min = int.MaxValue;
        foreach (string[] arg in args)
        {
            min = Mathf.Min(min, arg.Length);
        }
        string[] result = new string[min];
        for (int i = min; --i >= 0;)
        {
            string[] arg = new string[argsLength];
            for (int j = argsLength; --j >= 0;)
            {
                arg[j] = args[j][i];
            }
            result[i] = string.Format(format, arg);
        }
        return result;
    }
}
