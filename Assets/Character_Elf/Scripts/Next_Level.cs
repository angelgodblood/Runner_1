using UnityEngine.SceneManagement;
using UnityEngine;

public class Next_Level : MonoBehaviour
{
    public string Nextlvl;
    private int i;

    void Start()
    {
        i = SceneManager.GetActiveScene().buildIndex;
    }
    public void Next()
    {
        SceneManager.LoadScene(i + 1);
    }
}
