using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float gameStartTime = 0f;

    // Runs before any Start() functions run
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("There can only be one GameManager, deleting self.");
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);
    }
}
