using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ВDailyTask;

namespace ВDailyTask.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для CityModelBuilder</summary>
    [TestClass]
    [PexClass(typeof(CityModelBuilder))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CityModelBuilderTest
    {

        /// <summary>Тестовая заглушка для CreateCityModel(String)</summary>
        [PexMethod]
        internal CityModel CreateCityModelTest([PexAssumeUnderTest]CityModelBuilder target, string cityName)
        {
            CityModel result = target.CreateCityModel(cityName);
            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.X!=Double.NaN, "x was not identify");
            PexAssert.IsTrue(result.Y != Double.NaN, "y was not identify");


            return result;
            // TODO: добавление проверочных утверждений в метод CityModelBuilderTest.CreateCityModelTest(CityModelBuilder, String)
        }
    }
}
