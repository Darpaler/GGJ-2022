using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Debug.Log("You won!");
    }
}
