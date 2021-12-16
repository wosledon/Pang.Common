using System;
using System.Globalization;

namespace Pang.Common.Utils.DateTimeUtils;

public static class DateTimeExtension
{
    /// <summary>
    /// 字符串转为时间
    /// </summary>
    /// <param name="str"> </param>
    /// <returns> </returns>
    public static DateTime? ToDateTimeOrNull(this string str)
    {
        if (string.IsNullOrEmpty(str) ||
            string.IsNullOrWhiteSpace(str))
        {
            return null;
        }

        if (DateTime.TryParse(str, out var result))
        {
            return result;
        }

        return null;
    }

    /// <summary>
    /// 字符串转时间
    /// </summary>
    /// <param name="str">         </param>
    /// <param name="isFromExcel"> </param>
    /// <returns> </returns>
    // ReSharper disable once MethodOverloadWithOptionalParameter
    public static DateTime? ToDateTimeOrNull(this string str, bool isFromExcel = false)
    {
        if (!isFromExcel)
        {
            return str.ToDateTimeOrNull();
        }

        var dateTimeSplit = str.Split(' ');
        var date = dateTimeSplit[0];
        var time = dateTimeSplit[1];

        // 适配 Excel 上传的 12/16/21 20:28 的时间形式
        var dateList = date.Split('/');
        if (dateList.Length > 1)
        {
            if (dateList[0].Length > 2)
            {
                return str.ToDateTimeOrNull();
            }
            else
            {
                DateTime.TryParseExact(str, "MM/dd/yy HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out var result);

                return result;
            }
        }

        return null;
    }
}