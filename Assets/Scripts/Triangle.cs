using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Cube
{
    string name;
    Color color;

    public Triangle() { name = "Triangle"; color = Color.white; }

    public override string GetShape()
    {
        return name;
    }
}
