using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScriptManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SystemDataManager.Instance.LoadSystemData();
        SystemDataManager.Instance.SaveSystemData();
    }

    public void UpdateSettings()
    {
        SystemDataManager.Instance.SaveSystemData();
    }
}
