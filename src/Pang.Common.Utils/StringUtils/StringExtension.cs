using System;

namespace Pang.Common.Utils.StringUtils;

/// <summary>
/// 字符串扩展类
/// </summary>
public static class StringExtension
{
    /// <summary>
    /// 转Int16
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static short ToInt16(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        Int16.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 转Short
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static short ToIntShort(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        Int16.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 转Int
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static int ToInt(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        Int32.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 转Int32
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static int ToInt32(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        Int32.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 转Long
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static long ToIntLong(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        Int64.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 转Int64
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static long ToInt64(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        Int64.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 转浮点数
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static float ToFloat(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0f;
        }

        float.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 转双精度浮点数
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static double ToDouble(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return 0d;
        }

        double.TryParse(str.ReplaceWhiteSpace(), out var result);

        return result;
    }

    /// <summary>
    /// 置换掉所有空格
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static string ReplaceWhiteSpace(this string str)
    {
        return str.Replace(" ", "");
    }

    public static string? ToStringOrDefault(this object? obj)
    {
        return obj is null ? string.Empty : obj.ToString();
    }
}