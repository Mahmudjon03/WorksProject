using Xunit;
using System;
using ConsoleApp;

namespace TestMyParollClass
{
    public class PayrollTest : IDisposable
    {

        Payroll testCase;
        public PayrollTest()
        {
            testCase = new Payroll();
            //testCase.Hours = 20;
            //testCase.Hourly = 10;
        }
        public void Dispose()
        {
           
        }

        [Theory]
        [InlineData(20,10,200)]
        [InlineData(50, 10, 550)]

        public void TestGrossPayCorrect(Decimal hours,Decimal rate, Decimal expected)
        {
            //Decimal expected = 200;
          
            testCase.Hourly = rate;
            
            testCase.Hours = hours;
            
            Decimal actual = testCase.GrossPay;
            
            Assert.Equal(expected, actual);


        }
        [Theory]
        [InlineData(20, 10, 7)]
        [InlineData(50, 10, 19.25)]
        public void TestLocalGrossPayIsCorrect(Decimal hours, Decimal rate, Decimal expected) {
           
            Decimal taxRate = (Decimal).035;
            testCase.Hours = hours;
            testCase.Hourly= rate; 
           
          //Decimal expected = 200*(Decimal).035;
            
            Decimal actual = testCase.LocalTaxes(taxRate);
            
            Assert.Equal(expected, actual);
        }

    }
}