using UnityEngine;

namespace KristinaWaldt.ExtensionMethods
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Rounds the xy and returns them as a Vector2Int.
        /// z is discarded.
        /// </summary>
        public static Vector2Int ToVector2Int(this Vector3 original)
        {
            return new Vector2Int(Mathf.RoundToInt(original.x), Mathf.RoundToInt(original.y));
        }
        
        /// <summary>
        /// Rounds the xy and returns them as a Vector2Int.
        /// </summary>
        public static Vector2Int ToVector2Int(this Vector2 original)
        {
            return new Vector2Int(Mathf.RoundToInt(original.x), Mathf.RoundToInt(original.y));
        }
    }
}
