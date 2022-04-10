using UnityEngine;

namespace KristinaWaldt.ExtensionMethods
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Returns a Vector3 with the direction to the transform.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 DirectionTo(this Transform source, Transform destination)
        {
            return source.position.DirectionTo(destination.position);
        }
        
        public static void Reset(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public static void DestroyChildren(this Transform transform)
        {
            for (int i = transform.childCount - 1; i >= 0; i--)
            {
                Object.Destroy(transform.GetChild(i).gameObject);
            }
        }
    }
}
