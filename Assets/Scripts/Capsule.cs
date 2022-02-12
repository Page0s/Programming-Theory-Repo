using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE inherited class
[RequireComponent(typeof(MeshRenderer))]
public class Capsule : Shape
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

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
            ShapeSpawner.Instance.SpawnNewShape();
        }
    }
}
