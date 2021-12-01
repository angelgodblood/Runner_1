using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Game : MonoBehaviour
{
    public string Level_1;
    public void Play_game()
    {
        SceneManager.LoadScene(Level_1);
    }
}
