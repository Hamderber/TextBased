using Newtonsoft.Json;
using System.IO;
using UnityEngine;

public class SystemDataManager
{
    private string _applicationDataPath { get; set; }
    private string _applicationDataPathSettings { get; set; }
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
        if (!Directory.Exists(_applicationDataPath))
        {
            Directory.CreateDirectory(_applicationDataPath);
            Debug.Log($"Directory {_applicationDataPath} did not exist, created that directory.");
        }
        Debug.Log($"Application data path is {_applicationDataPath}.");

    }

    /// <summary>
    /// No overrides = Load system settings.
    /// String override of source (for Debug.Log)
    /// </summary>
    public void LoadSystemData()
    {
        if (Data != null)
        {
            return;
        }
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

    public void LoadSystemData(string source)
    {
        Debug.Log($"Attempting to load data from path {_applicationDataPathSettings} due to {source}.");
        if (Data != null)
        {
            return;
        }
        if (!File.Exists(_applicationDataPathSettings))
        {
            Data = new SystemData();
        }
        else
        {
            var json = File.ReadAllText(_applicationDataPathSettings);
            Data = JsonConvert.DeserializeObject<SystemData>(json);
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
    /// <summary>
    /// No overrides = Save system settings,
    /// String override of source (for Debug.Log)
    /// </summary>
    public void SaveSystemData(string source)
    {
        var json = JsonConvert.SerializeObject(Data);
        File.WriteAllText(_applicationDataPathSettings, json);
        Debug.Log($"Saved data to path {_applicationDataPathSettings} due to {source}.");
    }
}
