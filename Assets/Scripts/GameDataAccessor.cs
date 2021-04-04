using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataAccessor : MonoBehaviour
{
    public Text Score;
    public Text Player_Name;

    private void Update()
    {
        Player_Name.text = Data.Instance.player_name;
        Score.text = Data.Instance.score.ToString();
    }
}
