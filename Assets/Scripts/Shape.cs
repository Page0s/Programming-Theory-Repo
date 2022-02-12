using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected Color color;

    public virtual string GetShape()
    {
        return name;
    }

    public virtual Color GetColor()
    {
        return color;
    }
}
