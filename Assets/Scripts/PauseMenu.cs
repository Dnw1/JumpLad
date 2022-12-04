using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private static bool Paused;
    [SerializeField] private GameObject PauseMenuObject;

    //Set time to 1f in case of previous pause.
    private void Awake()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        Menu();
    }

    //Check if escape is pressed and either pause or continue depending on which.
    public void Menu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }
    //Stop time and pause the game.
    private void Stop()
    {
        PauseMenuObject.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }
    //Resume time and continue the game.
    public void Play()
    {
        PauseMenuObject.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
