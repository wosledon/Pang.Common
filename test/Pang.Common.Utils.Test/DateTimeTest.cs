using System;
using Pang.Common.Utils.DateTimeUtils;
using Xunit;
using Xunit.Abstractions;

namespace Pang.Common.Utils.Test
{
    public class DateTimeTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public DateTimeTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test1()
        {
            var d1 = "2021-12-16 20:34";

            _testOutputHelper.WriteLine(d1.ToDateTimeOrNull().ToString());

            var d2 = "2021/12/16 20:34";

            _testOutputHelper.WriteLine(d2.ToDateTimeOrNull().ToString());

            var d3 = "12/16/21 20:34:00";

            _testOutputHelper.WriteLine(d3.ToDateTimeOrNull(true).ToString());

            var d4 = "2021-12-16 20:34";

            _testOutputHelper.WriteLine(d1.ToDateTimeOrNull(false).ToString());
        }
    }
}