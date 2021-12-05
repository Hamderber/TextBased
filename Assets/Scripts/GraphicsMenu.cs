using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsMenu : MonoBehaviour
{
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;

    void Awake()
    {
        SetQuality(QualitySettings.GetQualityLevel());

        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        
        List<string> resolutionOptions = new List<string>();
        int currentResolutionIndex = 0;
        Debug.Log($"Current screen dimensions are {Screen.width}x{Screen.height}.");
        for (int i = 0; i < resolutions.Length; i ++ )
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            Debug.Log($"Added resolution {option} to the list of resolution options.");
            resolutionOptions.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
                Debug.Log($"Set the default resolution to {option}.");
            }
            
        }

        resolutionDropdown.AddOptions(resolutionOptions);
        if (currentResolutionIndex == 0)
        {
            Debug.Log($"Current resolution of {Screen.width}x{Screen.height} isn't compatible with the generated options. Setting default resolution to {resolutions[0].width}x{resolutions[0].height}.");
        }
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetQuality(int i_qualityIndex)
    {
        Debug.Log($"Set game quality to {i_qualityIndex}.");
        QualitySettings.SetQualityLevel(i_qualityIndex);
    }

    public void ToggleFullscreen(bool b_isFullScreen)
    {
        Debug.Log($"Set fullscreen to {b_isFullScreen}");
        Screen.fullScreen = b_isFullScreen;
    }

    public void SetResolution(int i_resolutionIndex)
    {
        Resolution resolution = resolutions[i_resolutionIndex];
        Debug.Log($"Set screen resolution to {resolution.width}x{resolution.height} with Fullscreen = {Screen.fullScreen}.");
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
