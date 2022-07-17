using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pauseButton;
    
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Spaceship") == null)
        {
            gameOverPanel.SetActive(true);
            pauseButton.SetActive(false);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
