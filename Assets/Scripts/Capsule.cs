using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    private void Awake()
    {
        name = "Capsule";
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
