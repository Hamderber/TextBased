using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsMenu : MonoBehaviour
{
    private SystemData _systemData;

    public GameObject FullscreenToggle;
    public GameObject ResolutionDropdown;
    public GameObject QualityDropdown;

    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;

    private void Awake()
    {
        //Gets the singleton system data
        SystemDataManager.Instance.LoadSystemData("Graphics Menu refreshing");
        _systemData = SystemDataManager.Instance.Data;
        UpdateResolutionOptions();
        FullscreenToggle.GetComponent<Toggle>().isOn = _systemData.IsFullscreen;
        QualityDropdown.GetComponent<TMP_Dropdown>().value = _systemData.QualityIndex;
    }


    /// <summary>
    /// Looks at game screen resolution and checks if it is equal to one of the options. If it is, set the dropdown to that value.
    /// If not, sets resolution to minimum value. Also adds all options to the dropdown menu and refreshes it.
    /// </summary>
    public void UpdateResolutionOptions()
    {
        //Debug.Log("Updating resolution options");
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> resolutionOptions = new List<string>();
        //Debug.Log($"Current screen dimensions are {Screen.width}x{Screen.height}.");
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            //Debug.Log($"Added resolution {option} to the list of resolution options.");
            resolutionOptions.Add(option);
        }
        resolutionDropdown.AddOptions(_systemData.ResolutionOptions);
        if (_systemData.GameResolutionIndex == 0)
        {
            Debug.Log($"Current resolution of {Screen.width}x{Screen.height} isn't compatible with the generated options. Setting default resolution to {resolutions[0].width}x{resolutions[0].height}.");
        }
        resolutionDropdown.value = _systemData.GameResolutionIndex;
        ResolutionDropdown.GetComponent<TMP_Dropdown>().value = _systemData.GameResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }    
}
