using Conlose;
using System.Text.RegularExpressions;

namespace TestNumber
{
    public class TestNumber: IDisposable
    {

          MathTest test;
        public TestNumber()
        {
            test = new MathTest();
         }
        public void Dispose()
        {

        }
        [Fact]
        public void TestMatches()
        {
            string text = "012345|Accounts|EffectiveDate|Z1-M1|||2022-03-21|||2022-03-21 18:05:53.566";
           
            var pattern = new Regex($@"(.*?)|Accounts|EffectiveDate|Z1-M1|||(?.*)|||(.*?)");

            Assert.Matches(pattern, text);
        }
       [Theory]
        [InlineData(10,20,30)]
        [InlineData(40, 40, 30)]
        [InlineData(40, 10, 50)]
        public void TestMathSum(int n1, int n2,int n3)
        {
           int result= test.SumNumber(n1,n2);
          
           int experted = n3;
            
           Assert.Equal(experted,result);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void TestMathBool(bool reques)
        {
            bool result = test.BoolAction(reques);

              Assert.True(result);
        }
        [Fact]
        public void TestType()
        {

            var expected = typeof(string);
            var result = test.TestString("test");

            Assert.IsType(expected, result);
        }
        [Fact]
        public void TestIsNull()
        {
            var result = test.TestString("test");
          
           
            Assert.NotNull(result);
        }
           
    }
}