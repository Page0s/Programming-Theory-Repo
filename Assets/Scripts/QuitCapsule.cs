using UnityEngine;
#if UNTY_EDITOR
using UnityEditor
#endif

public class QuitCapsule : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
             Application.Quit();
#endif
        }
    }
}
