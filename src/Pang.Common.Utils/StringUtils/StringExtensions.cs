using System;

namespace Pang.Common.Utils.StringUtils;

/// <summary>
/// 字符串扩展类
/// </summary>
public static class StringExtensions
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

        Int16.TryParse(str, out var result);

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

        Int16.TryParse(str, out var result);

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

        Int32.TryParse(str, out var result);

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

        Int32.TryParse(str, out var result);

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

        Int64.TryParse(str, out var result);

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

        Int64.TryParse(str, out var result);

        return result;
    }
}