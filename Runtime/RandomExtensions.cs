using System.Collections.Generic;
using UnityEngine;

namespace KristinaWaldt
{
	public static class RandomExtensions
	{
		/// <summary>
		/// Use the int as percentage and return if it happened.
		/// </summary>
		/// <param name="chance"></param>
		/// <returns></returns>
		public static bool UseAsChance(this int chance)
		{
			int randomPercentage = Random.Range(1, 101);
			return randomPercentage <= chance.ClampToPercentage();
		}

		public static int ClampToPercentage(this int percentage)
		{
			return Mathf.Clamp(percentage, 0, 100);
		}

		public static int GetRandomInRange(this Vector2Int range)
		{
			return Random.Range(range.x, range.y);
		}
		
		public static float GetRandomInRange(this Vector2 range)
		{
			return Random.Range(range.x, range.y);
		}
		
		public static int GetRandomIndex<T>(this List<T> list)
		{
			return Random.Range(0, list.Count);
		}

		public static T GetRandom<T>(this List<T> list)
		{
			return list[list.GetRandomIndex()];
		}
	}
}
