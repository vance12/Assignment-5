using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Dropdown gameSpeed;

    public InputField Player_name;

    public void SetData()
    {
        Data.Instance.player_name = Player_name.text;
        if (gameSpeed.value == 0)
        {
            Data.Instance.gameSpeed = 1;
        }
        if (gameSpeed.value == 1f)
        {
            Data.Instance.gameSpeed = 1.5f;
        }
        if (gameSpeed.value == 2)
        {
            Data.Instance.gameSpeed = 2f;
        }

    }
}

