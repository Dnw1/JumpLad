using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    public float currentTime;

    private void Update()
    {
        ManageTimer();
    }
    //Set the current time and display it on the text.
    private void ManageTimer()
    {
            currentTime = currentTime += Time.deltaTime;
            timerText.text = currentTime.ToString("0.00");
    }
    //Lower the current time when triggered depending on the value given.
    public void LowerTime(float _value)
    {
        currentTime = currentTime - _value;
    }
}
