using Xunit;

namespace VsClassLibrary.Tests
{
    [VsTestSettings(UIThread = true)]
    public class DteUtilitiesTests
    {
        [VsFact(Version = "2022")]
        void TestMethod17()
        {
            Assert.Equal("17.0", DteUtilities.GetVsVersion());
        }

        [VsFact(Version = "2019")]
        void TestMethod16()
        {
            Assert.Equal("16.0", DteUtilities.GetVsVersion());
        }

        [VsFact(Version = "2017")]
        void TestMethod15()
        {
            Assert.Equal("15.0", DteUtilities.GetVsVersion());
        }
    }
}
