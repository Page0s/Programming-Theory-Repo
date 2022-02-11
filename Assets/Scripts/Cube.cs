using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    string name;

    public Cube() { name = "Cube"; }

    public override string GetShape()
    {
        return name;
    }
}
