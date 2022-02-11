using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Shape shape = new Cube();
        Debug.Log("shape is: " + shape.GetShape());
    }
}
