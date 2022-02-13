using UnityEngine;

public class ResetSphere : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            ShapeSpawner.Instance.RespawnAllShapes();
    }
}
