using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    [SerializeField] private GoalVictory[] GoalZones;

    private void OnEnable()
    {
        GoalVictory.OnGoalSuccess += CheckLevelSuccess;
    }

    private void OnDisable()
    {
        GoalVictory.OnGoalSuccess -= CheckLevelSuccess;
    }

    public void CheckLevelSuccess()
    {
        //If any goals are failed, return early
        for (int i = 0; i < GoalZones.Length; i++)
        {
            if (GoalZones[i].isSuccess == false)
            {
                return;
            }
        }

        

        //Else all goals succeed
        OnLevelSuccess();
    }

    public void OnLevelSuccess()
    {
        Debug.Log("Level Cleared.");
        // Loads the next scene by build index.
        if(SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCountInBuildSettings - 1)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
