
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete1 : MonoBehaviour
{ 
        public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
}

}
