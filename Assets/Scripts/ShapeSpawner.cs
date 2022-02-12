using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public static ShapeSpawner Instance { get; private set; }

    [SerializeField] List<GameObject> shapeList;

    List<GameObject> shapes;
    Vector3 firstSpawn = new Vector3(-2f, 2f, 0f);
    private int rows = 3;
    private int columns = 4;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            shapes = new List<GameObject>();

            for(int i = 0; i < rows; ++i)
            {
                for(int j = 0; j < columns; ++j)
                {
                    GameObject shape = Instantiate(shapeList[Random.Range(0, shapeList.Count)]);
                    shape.SetActive(true);
                    shape.transform.position = firstSpawn;
                    firstSpawn.x += 2f;
                    shapes.Add(shape);
                }
                firstSpawn.x = -2f;
                firstSpawn.y -= 2f; 
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SpawnNewShape()
    {
        Vector3 position = Vector3.zero;
        int index = 0;

        shapes.ForEach(shape =>
        {
            if (!shape.gameObject.activeInHierarchy)
            {
                position = shape.transform.position;
                index = shapes.IndexOf(shape);
                Destroy(shape);
            }
        });
        shapes.RemoveAt(index);
        GameObject shape = Instantiate(shapeList[Random.Range(0, shapeList.Count)]);
        shape.transform.position = position;
        shape.transform.rotation = Quaternion.identity;
        shape.SetActive(true);
        shapes.Add(shape);
    }
}
