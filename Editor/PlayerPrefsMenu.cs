using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UniExt
{
    public static class PlayerPrefsMenu
    {
        [MenuItem("Tools/Clear PlayerPrefs")]
        public static void ClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();

            Debug.Log("Clear PlayerPrefs");
        }

    }
}
