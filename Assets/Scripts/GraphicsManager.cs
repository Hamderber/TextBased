using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GraphicsManager : MonoBehaviour
{
    private SystemData _systemData;

    Resolution[] resolutions;

    private void Start()
    {
        //Gets the singleton system data
        SystemDataManager.Instance.LoadSystemData();
        _systemData = SystemDataManager.Instance.Data;
        DetermineResolutionOptions();
        SetQuality(_systemData.QualityIndex);
    }


    /// <summary>
    /// Looks at game screen resolution and checks if it is equal to one of the options. If it is, set the dropdown to that value.
    /// If not, sets resolution to minimum value. Also adds all options to the dropdown menu and refreshes it.
    /// </summary>
    public void DetermineResolutionOptions()
    {
        resolutions = Screen.resolutions;

        List<string> resolutionOptions = new List<string>();

        //List<string> resolutionOptions = new List<string>();
        int currentResolutionIndex = 0;
        Debug.Log($"Current screen dimensions are {Screen.width}x{Screen.height}.");
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            Debug.Log($"Added resolution {option} to the list of resolution options.");
            //resolutionOptions.Add(option);
            resolutionOptions.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
                Debug.Log($"Set the default resolution to {option}.");
            }

        }

        Debug.Log(_systemData.ResolutionOptions);
        _systemData.ResolutionOptions = resolutionOptions;

        //resolutionDropdown.AddOptions(resolutionOptions);
        if (currentResolutionIndex == 0)
        {
            Debug.Log($"Current resolution of {Screen.width}x{Screen.height} isn't compatible with the generated options. Setting default resolution to {resolutions[0].width}x{resolutions[0].height}.");
        }
    }
    public void SetQuality(int qualityIndex)
    {
        Debug.Log($"Set game quality to {qualityIndex}.");
        _systemData.QualityIndex = qualityIndex;
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void ToggleFullscreen(bool isFullcreen)
    {
        Debug.Log($"Set fullscreen to {isFullcreen}");
        _systemData.IsFullscreen = isFullcreen;
        Screen.fullScreen = isFullcreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Debug.Log($"Set screen resolution to {resolution.width}x{resolution.height} with Fullscreen = {_systemData.IsFullscreen}.");
        _systemData.GameResolutionIndex = resolutionIndex;
        Screen.SetResolution(resolution.width, resolution.height, _systemData.IsFullscreen);
    }
}
