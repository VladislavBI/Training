using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВDailyTask
{
    class CityDistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistanceBetweenObjects(object firstObject, object secondObject)
        {
            if (firstObject is CityModel && secondObject is CityModel)
            {
                double xDistance, yDistance;
                GetOneDimensionalDistances(firstObject as CityModel, secondObject as CityModel, out xDistance, out yDistance);

                return AdvanceMathFuctionsService.GetHypotenuse(xDistance, yDistance);
            }
            else
            {
                if (firstObject is CityModel)
                {
                    throw new NotACityException(nameof(secondObject));
                }
                throw new NotACityException(nameof(firstObject));
            }
        }

        private static void GetOneDimensionalDistances(CityModel firstCity, CityModel secondCity, out double xDistance, out double yDistance)
        {
            xDistance = Math.Abs(firstCity.X - secondCity.X);
            yDistance = Math.Abs(firstCity.Y - secondCity.Y);
        }
    }

    class NotACityException : Exception
    {
        private const string exceptionMessage = " is not a CityModel";
        public NotACityException(string failedObjectName) : base(failedObjectName + exceptionMessage)
        { }
        public NotACityException(string failedObjectName, System.Exception inner) : base(failedObjectName + exceptionMessage, inner) { }
        protected NotACityException(System.Runtime.Serialization.SerializationInfo info,
       System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
