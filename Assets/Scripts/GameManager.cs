using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform fuelBar;
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
            if(value < 0)
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
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        fuelBar.localPosition = new Vector3(startX, 0f, valueZ);
        fuelBar.localScale = new Vector3(1f, startY, 1f);
    }

    public void IncreaseFuel() 
    {
        if (!isRocketFull)
        {
            fuelBar.localPosition = new Vector3(startX += (totalXY * percentageIncrement), 0f, valueZ);
            fuelBar.localScale = new Vector3(1f, startY += (totalXY * percentageIncrement), 1f);

            if(fuelBar.localPosition == new Vector3(endX, 0f, valueZ))
            {
                isRocketFull = true;
                if(OnFuelMax != null)
                    OnFuelMax.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
