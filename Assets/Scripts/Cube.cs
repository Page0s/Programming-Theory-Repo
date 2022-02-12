using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void Awake()
    {
        name = "Cube";
        color = Color.white;
    }

    public override string GetShape()
    {
        return name;
    }
}
