using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ВDailyTask;

namespace DistanceBetweenCities.Tests
{
    [TestClass]
    public class CityDistanceCalculatorTest
    {
        CityDistanceCalculator distanceCalculator = new CityDistanceCalculator();
        [TestMethod]
        [ExpectedException(typeof(NotACityException),
        "catch null object type")]
        public void SecondObjectsNull()
        {
            double result = distanceCalculator.CalculateDistanceBetweenObjects(new CityModel(), null);
        }
        [TestMethod]
        [ExpectedException(typeof(NotACityException),
        "catch null object type")]
        public void FirstObjectsNull()
        {
            double result = distanceCalculator.CalculateDistanceBetweenObjects(null, new CityModel());
        }
        [TestMethod]
        public void RightResultTest()
        {
            double result = distanceCalculator.CalculateDistanceBetweenObjects(new CityModel() {X=4, Y=5 }, new CityModel() { X = 1, Y = 1 });
            Assert.AreEqual(5, result, result+" != 5, wrong calculation!");
        }
    }
}
