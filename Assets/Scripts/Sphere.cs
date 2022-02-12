using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Awake()
    {
        name = "Sphere";
        color = Color.white;
    }

    public override string GetShape()
    {
        return name;
    }

    public override Color GetColor()
    {
        return color;
    }
}
