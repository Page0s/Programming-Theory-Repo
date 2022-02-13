using System.Collections.Generic;
using UnityEngine;

public class QuestCombination : MonoBehaviour
{
    public static QuestCombination Instance { get; private set; }

    [SerializeField] List<GameObject> questShapes;

    GameObject questShape;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        // ABSTRACTION
        SpawnNewRandomShape();
    }

    public void SpawnNewRandomShape()
    {
        questShape = Instantiate(questShapes[Random.Range(0, questShapes.Count)], transform);
        questShape.SetActive(true);
    }

    // POLYMORPHISM we are returning value from inhareted shape
    public string GetShapeName()
    {
        return questShape.GetComponent<Shape>().GetShape();
    }

    // POLYMORPHISM we are returning value from inhareted shape
    public Color GetShapeColor()
    {
        return questShape.GetComponent<Shape>().GetColor();
    }

    public void DestroyCurrentShape()
    {
        Destroy(questShape);
    }
}
