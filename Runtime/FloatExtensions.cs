using UnityEngine;

namespace KristinaWaldt.ExtensionMethods
{
    public static class FloatExtensions
    {
        public static float Remap(this float value, float iMin, float iMax, float oMin, float oMax)
        {
            float t = Mathf.InverseLerp(iMin, iMax, value);
            return Mathf.Lerp(oMin, oMax, t);
        }
    }
}