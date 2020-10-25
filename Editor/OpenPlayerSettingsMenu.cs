using UnityEditor;

namespace UniExt
{
    public static class OpenPlayerSettingsMenu
    {
        [MenuItem("Tools/Player Settings")]
        private static void OpenPlayerSettings()
        {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
        }
    }
}
