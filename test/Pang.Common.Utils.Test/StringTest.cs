using System;
using System.Data.SqlTypes;
using Pang.Common.Utils.StringUtils;
using Xunit;

namespace Pang.Common.Utils.Test;

public class StringTest
{
    internal class Student
    {
        public string? Name { get; set; }
    }

    [Fact]
    public void Test1()
    {
        Student? s = null;
        var res = s.ToStringOrDefault();
        Assert.True(res?.Equals(string.Empty));
    }
}