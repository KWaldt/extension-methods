using UnityEngine;

namespace KristinaWaldt.ExtensionMethods
{
	public static class AnimationCurveExtensions
	{
		public static bool IsValid(this AnimationCurve animationCurve)
		{
			return animationCurve.keys.Length > 0;
		}
	}
}
