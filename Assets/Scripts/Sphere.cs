using UnityEngine;

// INHERITANCE inherited class
[RequireComponent(typeof(MeshRenderer))]
public class Sphere : Shape
{
    private void Awake()
    {
        name = "Sphere";
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = GetRandomColor();
    }

    // ENCAPSULATION
    public override string GetShape()
    {
        return name;
    }

    public override Color GetColor()
    {
        return meshRenderer.material.color;
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
            ShapeSpawner.Instance.SpawnNewShape();
            GameManager.Instance.CheckIfQuestCorrect(GetShape(), GetColor());
        }
    }
}
