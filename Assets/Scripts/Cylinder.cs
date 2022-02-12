using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Cube
{
    private void Awake()
    {
        name = "Cylinder";
        color = Color.white;
    }

    public override string GetShape()
    {
        return name;
    }
}
