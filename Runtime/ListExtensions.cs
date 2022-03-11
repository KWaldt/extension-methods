using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal;

namespace KristinaWaldt.ExtensionMethods
{
	public static class ListExtensions
	{
		public static void AddIfUnique<T>(this List<T> list, T item)
		{
			if (list.Contains(item))
				return;
			
			list.Add(item);
		}

		public static T PopIfPossible<T>(this Stack<T> stack)
		{
			return stack.Count == 0 ? default : stack.Pop();
		}

		public static bool IsEmpty<T>(this Stack<T> stack)
		{
			return stack.Count == 0;
		}

		public static List<T> ValuesToList<TY, T>(this Dictionary<TY, T> dictionary)
		{
			return dictionary.Values.ToList();
		}
	}
}
