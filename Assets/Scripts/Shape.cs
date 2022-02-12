using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE base class
public abstract class Shape : MonoBehaviour
{
    protected MeshRenderer meshRenderer;

    protected Color GetRandomColor()
    {
        List<Color> colors = new List<Color>() 
        { 
            Color.white, Color.green, Color.blue, Color.cyan, Color.magenta, Color.red, Color.yellow 
        };

        return colors[Random.Range(0, colors.Count)];
    }

    // ENCAPSULATION
    public virtual string GetShape()
    {
        return name;
    }

    // ENCAPSULATION
    public virtual Color GetColor()
    {
        return meshRenderer.material.color;
    }
}
