using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform fuelBar;
    [SerializeField] GameObject endGame;
    public static GameManager Instance { get; private set; }
    public event EventHandler OnFuelMax;

    float startX = -0.9f;
    float startY = 0.1f;
    float totalXY = 2.2f;
    float endX = 1.3f;
    float valueZ = -0.23f;
    float percentageIncrement = 0.1f;
    int score;
    bool isRocketFull;

    // ENCAPSULATION protecting score input value
    public int Score
    {
        get { return score; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative value!");
            }
            else
            {
                score = value;
            }
        }
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        // setting up fuell bar to minimum level
        fuelBar.localPosition = new Vector3(startX, 0f, valueZ);
        fuelBar.localScale = new Vector3(1f, startY, 1f);
    }

    private void Start()
    {
        OnFuelMax += GameManager_OnFuelMax;
    }

    private void GameManager_OnFuelMax(object sender, EventArgs e)
    {
        endGame.gameObject.SetActive(true);
    }

    // Increasing fuell level by a percentage level
    void IncreaseFuel()
    {
        if (!isRocketFull)
        {
            fuelBar.localPosition = new Vector3(startX += (totalXY * percentageIncrement), 0f, valueZ);
            fuelBar.localScale = new Vector3(1f, startY += (totalXY * percentageIncrement), 1f);

            // if fuell level is maximum than we send notification event
            if (fuelBar.localPosition == new Vector3(endX, 0f, valueZ))
            {
                isRocketFull = true;
                if (OnFuelMax != null)
                    OnFuelMax.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public void CheckIfQuestCorrect(string shapeName, Color shapeColor)
    {
        if(shapeName == QuestCombination.Instance.GetShapeName() && shapeColor == QuestCombination.Instance.GetShapeColor())
        {
            IncreaseFuel();
            QuestCombination.Instance.DestroyCurrentShape();
            QuestCombination.Instance.SpawnNewRandomShape();
        }
    }
}
