using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI setTimer;
    [SerializeField] private GameObject timer;

    private float finalTime;

    //Get the time player needed to reach endgame from timer and display it.
    public void GrabTiming()
    {
        finalTime = timer.GetComponent<Timer>().currentTime;
        setTimer.text = finalTime.ToString("0.00");
    }
}
