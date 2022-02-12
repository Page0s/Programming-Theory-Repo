using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
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

    int score;

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
    }
}
