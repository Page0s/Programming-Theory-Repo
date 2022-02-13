using UnityEngine;

// INHERITANCE inherited class
[RequireComponent(typeof(MeshRenderer))]
public class QuestSphere : Shape
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

    // ENCAPSULATION
    public override Color GetColor()
    {
        return meshRenderer.material.color;
    }
}
