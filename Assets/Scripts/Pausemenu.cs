using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Data.Instance.paused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
    }

    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        Data.Instance.paused = false;
        Data.Instance.gameSpeed = Data.Instance.tempSpeed;
    }

    void GamePause()
    {
        Data.Instance.tempSpeed = Data.Instance.gameSpeed;
        pauseMenuUI.SetActive(true);
        Data.Instance.gameSpeed = 0f;
        Data.Instance.paused = true;
    }
}
