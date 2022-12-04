using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectible : MonoBehaviour
{
    public bool GotKey { get; private set; }
    
    //Set bool to false.
    private void Awake()
    {
        GotKey = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if player and then set bool to true and deactivating gameObject.
        if (collision.tag == "Player")
        {
            GotKey = true;
            gameObject.SetActive(false);
        }
    }
}
