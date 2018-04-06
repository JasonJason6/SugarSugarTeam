using UnityEngine;
using System.Collections;

namespace SeanStandardScript
{
    public static class MathSean
    {
        public static float Map(float x, float in_min, float in_max, float out_min, float out_max)
        {
            return (x - in_min)*(out_max - out_min)/(in_max - in_min) + out_min;
        }

        public static float MapClamp(float x, float in_min, float in_max, float out_min, float out_max)
        {
            return Mathf.Clamp(Map(x, in_min, in_max, out_min, out_max), out_min, out_max);
        }

        //returns a random index i where 0 <= i < count with probabilities on the cdf curve
        public static int CDFRandomIndex(AnimationCurve cdf, int count)
        {
            return Mathf.FloorToInt(cdf.Evaluate(Random.value) * count);
        }
    }
}