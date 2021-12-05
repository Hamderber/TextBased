using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerDataManager
{
    private string _applicationDataPath { get; set; }
    private string _applicationDataPathGameSaves { get; set; }

    private string _applicationDataRoot { get; set; }

    private static PlayerDataManager _instance;
    public static PlayerDataManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PlayerDataManager();
            }
            return _instance;
        }
    }

    public PlayerData Data { get; set; }

    public PlayerDataManager()
    {
        _applicationDataRoot = Application.dataPath;
        _applicationDataPath = Path.Combine(_applicationDataRoot, "Saves");
        _applicationDataPathGameSaves = Path.Combine(_applicationDataPath, "Player.json");
        //hard code for one save for right now
        // in future maybe make list of saves in settings file in future reffering to save quantity

        if (!Directory.Exists(_applicationDataPath))
        {
            Directory.CreateDirectory(_applicationDataPath);
            Debug.Log($"Directory {_applicationDataPath} did not exist, created that directory.");
        }
        Debug.Log($"Player data path is {_applicationDataPath}.");
    }

    /// <summary>
    /// No overrides = Load system settings.
    /// String override of source (for Debug.Log)
    /// </summary>
    public void LoadPlayerData()
    {
        if (Data != null)
        {
            return;
        }
        if (!File.Exists(_applicationDataPathGameSaves))
        {
            Data = new PlayerData();
        }
        else
        {
            var json = File.ReadAllText(_applicationDataPathGameSaves);
            Data = JsonConvert.DeserializeObject<PlayerData>(json);
            Debug.Log($"Loaded data from path {_applicationDataPathGameSaves}.");
        }
    }

    public void LoadPlayerData(string source)
    {
        Debug.Log($"Attempting to load data from path {_applicationDataPathGameSaves} due to {source}.");
        if (Data != null)
        {
            return;
        }
        if (!File.Exists(_applicationDataPathGameSaves))
        {
            Data = new PlayerData();
            Debug.Log($"{_applicationDataPathGameSaves} didn't exist, making a new PlayerData object.");
            SavePlayerData("initial file creation");
        }
        else
        {
            var json = File.ReadAllText(_applicationDataPathGameSaves);
            Data = JsonConvert.DeserializeObject<PlayerData>(json);
        }
    }

    /// <summary>
    /// No overrides = Save system settings
    /// </summary>
    public void SavePlayerData()
    {
        var json = JsonConvert.SerializeObject(Data);
        File.WriteAllText(_applicationDataPathGameSaves, json);
        Debug.Log($"Saved data to path {_applicationDataPathGameSaves}.");
    }
    /// <summary>
    /// No overrides = Save system settings,
    /// String override of source (for Debug.Log)
    /// </summary>
    public void SavePlayerData(string source)
    {
        var json = JsonConvert.SerializeObject(Data);
        File.WriteAllText(_applicationDataPathGameSaves, json);
        Debug.Log($"Saved data to path {_applicationDataPathGameSaves} due to {source}.");
    }
}
