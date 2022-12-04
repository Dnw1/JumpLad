using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCollectible : MonoBehaviour
{
    [SerializeField] private float timeValue;
    [SerializeField] private GameObject Hourglass;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if tag is player and then trigger the LowerTime public void to decrease the current time by the value given and deactivating gameObject.
        if (collision.tag == "Player")
        {
            Hourglass.GetComponent<Timer>().LowerTime(timeValue);
            gameObject.SetActive(false);
        }
    }
}
