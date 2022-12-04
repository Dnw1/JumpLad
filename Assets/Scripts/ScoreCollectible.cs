using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollectible : MonoBehaviour
{
    [SerializeField] private float scoreValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if tag is player and then trigger the AddScore public void to increase score by the value given and deactivating gameObject.
        if (collision.tag == "Player")
        {
            collision.GetComponent<Score>().AddScore(scoreValue);
            gameObject.SetActive(false);
        }
    }
}
