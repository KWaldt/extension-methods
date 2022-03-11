using UnityEngine;
using UnityEngine.UI;

namespace KristinaWaldt.ExtensionMethods
{
    public static class ColorBlockExtension
    {
        /// <summary>
        /// Returns the color block with alternative colors.
        /// </summary>
        /// <param name="colorBlock"></param>
        /// <param name="normalColor"></param>
        /// <param name="highlightedColor"></param>
        /// <param name="pressedColor"></param>
        /// <param name="disabledColor"></param>
        /// <returns></returns>
        public static ColorBlock With(this ColorBlock colorBlock, Color? normalColor = null, Color? highlightedColor = null, Color? pressedColor = null, Color? disabledColor = null)
        {
            colorBlock.normalColor = normalColor ?? colorBlock.normalColor;
            colorBlock.highlightedColor = highlightedColor ?? colorBlock.highlightedColor;
            colorBlock.pressedColor = pressedColor ?? colorBlock.pressedColor;
            colorBlock.disabledColor = disabledColor ?? colorBlock.disabledColor;
            return colorBlock;
        }
    }
}