using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopup : MonoBehaviour
{
    [SerializeField] private GameObject Message;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if player tag and then reveal inactive text.
        if (collision.gameObject.tag == "Player")
        {
            Message.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Check if player tag left and then hide active text.
        if (collision.gameObject.tag == "Player")
        {
            Message.SetActive(false);
        }
    }
}
