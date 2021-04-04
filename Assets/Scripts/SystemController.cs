using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
public class SystemController : MonoBehaviour
{
    public void CreateSave()
    {
        SaveGame();
    }
    private Save CreateSaveGameObject()
    {
        Save save = new Save();

        save.playerName = Data.Instance.player_name;
        save.score = Data.Instance.score;
        save.lives = Data.Instance.lives;
        save.gameSpeed = Data.Instance.tempSpeed;


        return save;
    }
    public void SaveGame()
    {
        Save save = CreateSaveGameObject();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("Game Saved");
    }
    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            SceneManager.LoadScene("Main");

            Data.Instance.player_name = save.playerName;
            Data.Instance.score = save.score;
            Data.Instance.lives = save.lives;
            Data.Instance.gameSpeed = save.gameSpeed;

            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }
    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }
}
