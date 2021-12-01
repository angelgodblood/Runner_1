using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public string Menu;
    public void Exitgame()
    {
        SceneManager.LoadScene(Menu);
    }
}
