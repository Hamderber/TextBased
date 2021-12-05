using Newtonsoft.Json;
using System.IO;
using UnityEngine;

public class SystemDataManager
{
    private string _applicationDataPath { get; set; }

    private string _applicationDataPathSettings { get; set; }
    private string _applicationDataPathGameSaves { get; set; }

    private string _applicationDataRoot { get; set; }

    private static SystemDataManager _instance;
    public static SystemDataManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SystemDataManager();
            }
            return _instance;
        }
    }

    public SystemData Data { get; set; }

    public SystemDataManager()
    {
        _applicationDataRoot = Application.dataPath;
        _applicationDataPath = Path.Combine(_applicationDataRoot, "Settings");
        _applicationDataPathSettings = Path.Combine(_applicationDataPath, "Settings.json");
        _applicationDataPathGameSaves = Path.Combine(_applicationDataRoot, "Saves");
        //hard code for one save for right now
        // in future maybe make list of saves in settings file in future reffering to save quantity

        if (!Directory.Exists(_applicationDataPath))
        {
            Directory.CreateDirectory(_applicationDataPath);
            Debug.Log($"Directory {_applicationDataPath} did not exist, created that directory.");
        }
        Debug.Log($"Application data path is {_applicationDataPath}.");

        if (!Directory.Exists(_applicationDataPathGameSaves))
        {
            Directory.CreateDirectory(_applicationDataPathGameSaves);
            Debug.Log($"Directory {_applicationDataPathGameSaves} did not exist, created that directory.");
        }

    }

    /// <summary>
    /// No overrides = Load system settings
    /// </summary>
    public void LoadSystemData()
    {
        if (!File.Exists(_applicationDataPathSettings))
        {
            Data = new SystemData();
        }
        else
        {

            var json = File.ReadAllText(_applicationDataPathSettings);
            Data = JsonConvert.DeserializeObject<SystemData>(json);
            Debug.Log($"Loaded data from path {_applicationDataPathSettings}.");
        }
    }

    /// <summary>
    /// No overrides = Save system settings
    /// </summary>
    public void SaveSystemData()
    {
        var json = JsonConvert.SerializeObject(Data);
        File.WriteAllText(_applicationDataPathSettings, json);
        Debug.Log($"Saved data to path {_applicationDataPathSettings}.");
    }
}
