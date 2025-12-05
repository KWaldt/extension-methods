// <author>
//   PixelLifetime
//   https://forum.unity.com/threads/loop-through-serializedproperty-children.435119/
// </author>

using System.Collections.Generic;
using UnityEditor;

namespace KristinaWaldt.ExtensionMethods.Editor
{
    public static partial class SerializedPropertyExtensions
    {
        /// <summary>
        /// Gets all children of `SerializedProperty` at 1 level depth.
        /// </summary>
        /// <param name="serializedProperty">Parent `SerializedProperty`.</param>
        /// <returns>Collection of `SerializedProperty` children.</returns>
        public static IEnumerable<SerializedProperty> GetChildren(this SerializedProperty serializedProperty)
        {
            SerializedProperty currentProperty = serializedProperty.Copy();
            SerializedProperty nextSiblingProperty = serializedProperty.Copy();
            {
                nextSiblingProperty.Next(false);
            }
     
            if (currentProperty.Next(true))
            {
                do
                {
                    if (SerializedProperty.EqualContents(currentProperty, nextSiblingProperty))
                        break;
     
                    yield return currentProperty;
                }
                while (currentProperty.Next(false));
            }
        }
     
        // By PixelLifetime, https://forum.unity.com/threads/loop-through-serializedproperty-children.435119/
        /// <summary>
        /// Gets visible children of `SerializedProperty` at 1 level depth.
        /// </summary>
        /// <param name="serializedProperty">Parent `SerializedProperty`.</param>
        /// <returns>Collection of `SerializedProperty` children.</returns>
        public static IEnumerable<SerializedProperty> GetVisibleChildren(this SerializedProperty serializedProperty)
        {
            SerializedProperty currentProperty = serializedProperty.Copy();
            SerializedProperty nextSiblingProperty = serializedProperty.Copy();
            {
                nextSiblingProperty.NextVisible(false);
            }

            if (!currentProperty.NextVisible(true))
                yield break;
            
            do
            {
                if (SerializedProperty.EqualContents(currentProperty, nextSiblingProperty))
                    break;
     
                yield return currentProperty;
            }
            while (currentProperty.NextVisible(false));
        }

    }
}