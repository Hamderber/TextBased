using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMenu : MonoBehaviour
{
    private SystemData _systemData;
    public GameObject MasterVolumeSlider;
    public GameObject GameplayVolumeSlider;
    public GameObject MusicVolumeSlider;

    private void Awake()
    {
        //Gets the singleton system data
        SystemDataManager.Instance.LoadSystemData("Audio Menu refreshing");
        _systemData = SystemDataManager.Instance.Data;
        UpdateGameplayVolumeSlider();
        UpdateMasterVolumeSlider();
        UpdateMusicVolumeSlider();
    }
    public void UpdateMasterVolumeSlider()
    {
        MasterVolumeSlider.GetComponent<Slider>().value = _systemData.MasterVolume;
    }

    public void UpdateMusicVolumeSlider()
    {
        MusicVolumeSlider.GetComponent<Slider>().value = _systemData.MusicVolume;
    }
    public void UpdateGameplayVolumeSlider()
    {
        GameplayVolumeSlider.GetComponent<Slider>().value = _systemData.GameplayVolume;
    }
}
