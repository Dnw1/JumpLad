using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject player;
    private float currentScore;

    //Set the current score of the player and display it on the text.
    private void Update()
    {
        currentScore = player.GetComponent<Score>().currentScore;
        scoreText.text = currentScore.ToString("0");
    }
}
