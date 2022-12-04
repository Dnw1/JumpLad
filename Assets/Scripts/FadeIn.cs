using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] private GameObject timeTaken;
    public bool fade = false;

    private void Update()
    {
        //Check if allowed to start fading in endgame screen.
        if (fade)
        {
            //Get the players time taken to reach endgame.
            timeTaken.GetComponent<GetTime>().GrabTiming();
            //Fade in the endgame screen until fully visible.
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += Time.deltaTime;

                if (myUIGroup.alpha >= 1)
                {
                    fade = false;
                }
            }
        }
    }

    //Allows the start of the fading process.
    public void StartFade()
    {
        fade = true;
    }
}
