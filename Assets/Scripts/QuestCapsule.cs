using UnityEngine;

// INHERITANCE inherited class
[RequireComponent(typeof(MeshRenderer))]
public class QuestCapsule : Shape
{
    private void Awake()
    {
        name = "Capsule";
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
