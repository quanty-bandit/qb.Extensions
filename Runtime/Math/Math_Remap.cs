using UnityEngine;
namespace Extensions.Math_Remap
{
    public static class Math_Remap
    {
        public static float Remap(float value,
                                  float valueRangeMin, float valueRangeMax,
                                  float newRangeMin, float newRangeMax)
        {

            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }
        public static double Remap(double value,
                                  double valueRangeMin, double valueRangeMax,
                                  double newRangeMin, double newRangeMax)
        {

            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }
        public static int Remap(int value,
                                  int valueRangeMin, int valueRangeMax,
                                  int newRangeMin, int newRangeMax)
        {

            return Mathf.RoundToInt(Remap((float) value,(float)valueRangeMin,(float)valueRangeMax,(float)newRangeMin,(float)newRangeMax));
        }        

    }
}
