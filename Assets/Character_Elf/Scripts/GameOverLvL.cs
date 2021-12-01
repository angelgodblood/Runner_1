using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLvL : MonoBehaviour
{
    public GameObject GameOver;

    void Start()
    {
        Time.timeScale = 1;
        GameOver.SetActive(true);
        {
            Time.timeScale = 0;
        }

    }
}
