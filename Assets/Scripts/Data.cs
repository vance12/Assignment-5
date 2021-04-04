using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data Instance { get; private set; }

    public string player_name;

    public float gameSpeed;

    public int score;

    public bool paused;

    public float tempSpeed;

    public int lives;


    private void Start()
    {
        lives = 3;
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        Time.timeScale = Data.Instance.gameSpeed;
    }
}
