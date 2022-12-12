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
