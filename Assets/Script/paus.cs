using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paus : MonoBehaviour
{
    public static bool gameispaused = false;

    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                if (gameispaused)

                {
                    Resume();
                }
                else
                {
                    pause();
                }
        }
    }
    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    void pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }
    public void restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 0);
    }

    public void all_levels1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
}
