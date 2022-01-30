using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[RequireComponent(typeof(TextMeshProUGUI))]
public class Score : MonoBehaviour
{
    // Variables
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        TimeSpan finalTime = TimeSpan.FromSeconds(Time.time - GameManager.instance.gameStartTime);
        textMeshPro.text += " " + string.Format("{0:D2}:{1:D2}:{2:D2}", finalTime.Hours, finalTime.Minutes, finalTime.Seconds);
    }
}
