using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPin : MonoBehaviour
{
    private GoalVictory myGoal;
    public bool isSuccess { get; private set; } = false;

    private void Start()
    {
        //Set victory goal by parent
        myGoal = GetComponentInParent<GoalVictory>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {  
        //If victory object enters collider, this pin is successful
        if (collision.gameObject == myGoal.VictoryObject)
        {
            isSuccess = true;

            //Check for goal victory
            myGoal.CheckForVictory();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //If victory object leaves collider, this pin is failed
        if (collision.gameObject == myGoal.VictoryObject)
        {
            isSuccess = false;
        }
    }

}
