#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections.Generic;
using UnityEngine.Audio;
namespace Extensions.AudioMixer_GetExposedParameterNames
{
    public static class  AudioMixer_GetExposedParameterNames
    {
        /// <summary>
        /// Gets the exposed parameters names from the AudioMixer
        /// </summary>
        /// <param name="mixer">The extension target</param>
        /// <returns>The array of the exposed names</returns>
        public static string[] GetExposedParameterNames(this AudioMixer mixer)
        {
            List<string> exposedParams = new List<string>();
#if UNITY_EDITOR
            // Using reflection to access the AudioMixer's ExposedParameters
            var dynMixer = new SerializedObject(mixer);
            var parameters = dynMixer.FindProperty("m_ExposedParameters");

            if (parameters != null && parameters.isArray)
            {
                for (int i = 0; i < parameters.arraySize; i++)
                {
                    var param = parameters.GetArrayElementAtIndex(i);
                    var nameProp = param.FindPropertyRelative("name");
                    if (nameProp != null)
                    {
                        exposedParams.Add(nameProp.stringValue);
                    }
                }
            }
#endif
            return exposedParams.ToArray();
        }
    }
}
