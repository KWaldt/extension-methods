using System;
using System.Linq;
using UnityEngine;

namespace KristinaWaldt
{
	public class TypeHelper : MonoBehaviour
	{
		/// <summary>
		/// Returns non-abstract implementations of type that aren't a Unity Object.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static Type[] GetNativeImplementations<T>()
		{
			return GetImplementations<T>().Where(impl=>!impl.IsSubclassOf(typeof(UnityEngine.Object))).ToArray();
		}
		
		/// <summary>
		/// Returns non-abstract implementations of type.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static Type[] GetImplementations<T>()
		{
			var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes());

			var interfaceType = typeof(T);
			return types.Where(p => interfaceType.IsAssignableFrom(p) && !p.IsAbstract).ToArray();
		}
	}
}
