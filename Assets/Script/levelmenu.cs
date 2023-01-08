using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelmenu : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
    public void restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }


    public void restart21()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void leveiloader1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

