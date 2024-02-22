using WPFMySQLMVVM;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string a = WPFMySQLMVVM.ViewModel.CalculoUser.GetBirthYear("20");
            Assert.Equal("2004 - 2005", a);
        }
    }
}