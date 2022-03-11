using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace KristinaWaldt
{
	public static class VisualElementExtensions
	{
		public const string DisplayNoneClass = "display-none";
		
		public static void SetOrUnsetClass(this VisualElement element, string className, bool value)
		{
			if (element == null)
			{
				Debug.Log($"Element is null.");
				return;
			}
			
			if (value)
			{
				element.AddToClassList(className);
			}
			else
			{
				element.RemoveFromClassList(className);
			}
		}
		
		public static void SetDisplayNoneIfInvisible(this VisualElement element, bool isVisible)
		{
			element.SetOrUnsetClass(DisplayNoneClass, !isVisible);
		}
		
		public static void SetDisplayVisible(this VisualElement element, bool value)
		{
			element.visible = value;
			element.SetDisplayNoneIfInvisible(value);
		}
		
		public static void SetElementsVisibility(this List<VisualElement> elements, bool value)
		{
			foreach (VisualElement element in elements)
			{
				element.SetDisplayVisible(value);
			}
		}
	}
}
