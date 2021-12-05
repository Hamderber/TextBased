using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScriptManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SystemDataManager.Instance.LoadSystemData("Game Script Manager initialization");
        PlayerDataManager.Instance.LoadPlayerData("Game Script Manager initialization");
    }

    public void UpdateSettings()
    {
        SystemDataManager.Instance.SaveSystemData("saving menu changes");
    }
}
