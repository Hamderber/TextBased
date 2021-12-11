using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayScriptManager : MonoBehaviour
{
    private SystemData _systemData;

    private void Start()
    {
        //Gets the singleton system data
        SystemDataManager.Instance.LoadSystemData("Gameplay Script Manager initialization");
        _systemData = SystemDataManager.Instance.Data;
    }
    public void SetAutoSaveFrequency(int saveIndex)
    {
        if (saveIndex == 0) _systemData.AutoSaveFrequency = 30f;
        if (saveIndex == 1) _systemData.AutoSaveFrequency = 60f;
        if (saveIndex == 1) _systemData.AutoSaveFrequency = 300f;
        if (saveIndex == 1) _systemData.AutoSaveFrequency = 900f;
        if (saveIndex == 1) _systemData.AutoSaveFrequency = 1800f;
    }
}
