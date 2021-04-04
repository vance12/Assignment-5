using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadMenu()
    {
        Data.Instance.score = 0;
        SceneManager.LoadScene("Menu");
    }
    public void loadGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void loadEnd()
    {
        SceneManager.LoadScene("End");
    }
}
