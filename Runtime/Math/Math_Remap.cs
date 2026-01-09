using UnityEngine;
namespace Extensions.Math_Remap
{
    public static class Math_Remap
    {
        /// <summary>
        /// Remaps a float value from a source interval to a new one
        /// </summary>
        /// <param name="value">The source value</param>
        /// <param name="valueRangeMin">The min source range</param>
        /// <param name="valueRangeMax">The max source range</param>
        /// <param name="newRangeMin">The min destination range</param>
        /// <param name="newRangeMax">The max destination range</param>
        /// <returns>The value in the new range</returns>
        public static float Remap(float value,
                                  float valueRangeMin, float valueRangeMax,
                                  float newRangeMin, float newRangeMax)
        {

            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }
        /// <summary>
        /// Remaps a double value from a source interval to a new one
        /// </summary>
        /// <param name="value">The source value</param>
        /// <param name="valueRangeMin">The min source range</param>
        /// <param name="valueRangeMax">The max source range</param>
        /// <param name="newRangeMin">The min destination range</param>
        /// <param name="newRangeMax">The max destination range</param>
        /// <returns>The value in the new range</returns>
        public static double Remap(double value,
                                  double valueRangeMin, double valueRangeMax,
                                  double newRangeMin, double newRangeMax)
        {

            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }
        /// <summary>
        /// Remaps an int value from a source interval to a new one
        /// </summary>
        /// <param name="value">The source value</param>
        /// <param name="valueRangeMin">The min source range</param>
        /// <param name="valueRangeMax">The max source range</param>
        /// <param name="newRangeMin">The min destination range</param>
        /// <param name="newRangeMax">The max destination range</param>
        /// <returns>The value in the new range</returns>

        public static int Remap(int value,
                                  int valueRangeMin, int valueRangeMax,
                                  int newRangeMin, int newRangeMax)
        {

            return Mathf.RoundToInt(Remap((float) value,(float)valueRangeMin,(float)valueRangeMax,(float)newRangeMin,(float)newRangeMax));
        }        

    }
}
