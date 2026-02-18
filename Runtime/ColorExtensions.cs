using UnityEngine;

namespace KristinaWaldt.ExtensionMethods
{
    public static class ColorExtensions
    {
        public static Color With(this Color original, float? r = null, float? g = null, float? b = null, float? a = null)
        {
            return new (r ?? original.r, g ?? original.g, b ?? original.b, a ?? original.a);
        }

        public static Color SetAlpha(this Color original, float alpha)
        {
            return new (original.r, original.g, original.b, alpha);
        }

        public static string ToHex(this Color color)
        {
            return $"#{ColorUtility.ToHtmlStringRGB(color)}";
        }
        
        public static string ToHexWithAlpha(this Color color)
        {
            return $"#{ColorUtility.ToHtmlStringRGBA(color)}";
        }
    }
}