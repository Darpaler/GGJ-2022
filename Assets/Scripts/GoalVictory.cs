///
/// Checks multiple trigger boxes to ensure object is correctly positioned in goal to process victory.
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalVictory : MonoBehaviour
{
    [SerializeField] private GameObject victoryObject;
    public GameObject VictoryObject { get; private set; }
    private VictoryPin[] victoryPins;
    private bool m_isSuccess = false;
    public bool isSuccess { get { return m_isSuccess;} private set { } }



    public delegate void GoalSuccess();
    public static event GoalSuccess OnGoalSuccess;

    private void Start()
    {
        //Set accessible variables
        VictoryObject = victoryObject;

        //Set victory pins array
        victoryPins = GetComponentsInChildren<VictoryPin>();
    }

    public void CheckForVictory()
    {
        //If any pins are false, return early
        for (int i = 0; i < victoryPins.Length; i++)
        {
            if (victoryPins[i].isSuccess == false)
            {
                m_isSuccess = false;
                return;
            }                
        }

        //Else this goal is successful, fire OnGoalSuccess
        m_isSuccess = true;

        if (OnGoalSuccess != null)
            OnGoalSuccess();
    }


}
