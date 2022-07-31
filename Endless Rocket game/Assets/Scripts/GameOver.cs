using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject spaceship;
    
    void Update()
    {
        if(spaceship == null)
        {
            gameOverPanel.SetActive(true);
            pauseButton.SetActive(false);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
