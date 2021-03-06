// <copyright file="AdvanceMathFuctionsServiceTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ВDailyTask;

namespace ВDailyTask.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для AdvanceMathFuctionsService</summary>
    [PexClass(typeof(AdvanceMathFuctionsService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]

    [TestClass]
    public partial class AdvanceMathFuctionsServiceTest
    {
        /// <summary>Тестовая заглушка для GetHypotenuse(Double, Double)</summary>
        [PexMethod]
        internal double GetHypotenuseTest(double katetOne, double katetTwo)
        {
            double result = AdvanceMathFuctionsService.GetHypotenuse(katetOne, katetTwo);
            PexAssert.IsTrue(result >= 0, "result is "+result+". Sqrt can't be less than 0");
            return result;
        }
    }
}
