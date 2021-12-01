using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Game : MonoBehaviour
{
    private static bool GameIsPause = false;
    [SerializeField] private GameObject pauseMenu;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Continue();
            }
            else
            {
                Pause();
            }
            
        }
        
    }

   public void Continue()
    {
      pauseMenu.SetActive(false);
      Time.timeScale = 1f;
      GameIsPause = false;
    }

    void Pause()
    {
       pauseMenu.SetActive(true);
       Time.timeScale = 0f;
       GameIsPause = true;
    }

    
}
