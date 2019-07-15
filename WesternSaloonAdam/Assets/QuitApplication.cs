using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuitApplication : MonoBehaviour
{
    private void OnEnable()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
