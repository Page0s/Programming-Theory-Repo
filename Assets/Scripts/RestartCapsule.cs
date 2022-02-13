using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCapsule : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(0);
    }
}
