using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float currentScore { get; private set; }

    //Add score to the current score depending on the value given.
    public void AddScore(float _value)
    {
        currentScore = currentScore + _value;
    }
}
