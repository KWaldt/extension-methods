using System;
using System.Text.RegularExpressions;
using UnityEngine;

namespace KristinaWaldt.ExtensionMethods
{
	public static class StringExtensions
	{
		public static string UseForwardSlashes(this string input)
		{
			return input.Replace("\\", "/");;
		}
		
		public static string Truncate(this string value, int maxChars)
		{
			return value.Length <= maxChars ? value : value.Substring(0, maxChars) + (char)0x2026;
		}

		public static string AddSpacesBeforeUppercase(this string value)
		{
			return Regex.Replace(value, "([a-z])([A-Z])", "$1 $2");
		}

		public static string RemoveAfterLastUnderscore(this string value)
		{
			int lastIndex = value.LastIndexOf("_", StringComparison.Ordinal);
			lastIndex = lastIndex > -1 ? lastIndex : value.Length;
			return value.Substring(0, lastIndex);
		}
		
		public static string InColorTags(this string text, Color color)
		{
			return $"<color={color.ToHex()}>{text}</color>";
		}
        
		public static string InColorTags(this string text, string colorString)
		{
			if (string.IsNullOrEmpty(colorString))
				return text;
            
			return $"<color={colorString}>{text}</color>";
		}

	}
}
