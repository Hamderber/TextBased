using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScriptManager : MonoBehaviour
{
    private SystemData _systemData;
    public AudioMixer masterAudioMixer;

    private void Start()
    {
        //Gets the singleton system data
        SystemDataManager.Instance.LoadSystemData("Audio Script Manager initialization");
        _systemData = SystemDataManager.Instance.Data;
        SetMasterVolume(_systemData.MasterVolume);
        SetMusicVolume(_systemData.MusicVolume);
        SetGameplayVolume(_systemData.GameplayVolume);
    }
    public void SetMasterVolume(float masterVolumeSlider)
    {
        masterAudioMixer.SetFloat("MasterVolumeParameter", masterVolumeSlider);
        _systemData.MasterVolume = masterVolumeSlider;
        //Debug.Log($"Master volume changed to {masterVolumeSlider}.");
    }

    public void SetMusicVolume(float musicVolumeSlider)
    {
        masterAudioMixer.SetFloat("MasterVolumeParameter", musicVolumeSlider);
        _systemData.MusicVolume = musicVolumeSlider;
        //Debug.Log($"Music volume changed to {musicVolumeSlider}.");
    }
    public void SetGameplayVolume(float gameplayVolumeSlider)
    {
        masterAudioMixer.SetFloat("MasterVolumeParameter", gameplayVolumeSlider);
        _systemData.GameplayVolume = gameplayVolumeSlider;
        //Debug.Log($"Gameplay volume changed to {gameplayVolumeSlider}.");
    }
}
