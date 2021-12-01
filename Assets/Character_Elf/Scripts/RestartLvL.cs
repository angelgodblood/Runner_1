using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;


public class RestartLvL : MonoBehaviour
{
    public bool restart = false;
    
    //public CityTCV1 speed_2;

    private void Start()
    {
        //speed_2.speed = 6;
        //speed_2.maxSpeed = 50;
    }
    public void RestartLVL()
    {
        
        restart = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    
}
