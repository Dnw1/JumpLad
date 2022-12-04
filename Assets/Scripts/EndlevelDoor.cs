using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlevelDoor : MonoBehaviour
{
    KeyCollectible keyCollectible;
    [SerializeField] private GameObject kC;

    [SerializeField] private GameObject endGameMenu;
    [SerializeField] private GameObject fadeController;

    [SerializeField] private SpriteRenderer myrenderer;
    [SerializeField] private Sprite newSprite;

    //Get the Script from GameObject to allow checking of bool later.
    private void Awake()
    {
        keyCollectible = kC.GetComponent<KeyCollectible>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if player has gotten key and to go to endgame if true.
        if (collision.tag == "Player")
        {
            if (keyCollectible.GotKey == true) {
                //Change sprite from closed to open door.
                ChangeSprite();
                //Start fade in the endgame screen.
                endGameMenu.SetActive(true);
                fadeController.GetComponent<FadeIn>().fade = true;
            }
        }
    }
    //Set old sprite to new.
    private void ChangeSprite()
    {
        myrenderer.sprite = newSprite;
    }


}
