using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class NameSaver : MonoBehaviour
{

    public static NameSaver Instance;

    public InputField inputField;

    public string PlayerName;
    public string HSHolder;

    public int bestScore;

    public void Awake()
    {

        if (Instance != null)
        {

            Destroy(gameObject);
            return;

        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void displayText()
    {

        PlayerName = inputField.text;
        Debug.Log(PlayerName);

    }

    [System.Serializable]
    class SaveData
    {

        public int bestScore;
        public string HSHolder;

    }

    public void SaveScore()
    {

        SaveData data = new SaveData();
        data.bestScore = bestScore;
        data.HSHolder = HSHolder;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }

    public void LoadScore()
    {

        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {

            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HSHolder = data.HSHolder;
            bestScore = data.bestScore;

        }

    }
}
