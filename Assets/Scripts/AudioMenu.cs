using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMenu : MonoBehaviour
{

    public AudioMixer masterAudioMixer;

    public void SetMasterVolume (float f_masterVolumeSlider)
    {
        masterAudioMixer.SetFloat("MasterVolumeParameter", f_masterVolumeSlider);
        Debug.Log($"Master volume changed to {f_masterVolumeSlider}.");
    }

    public void SetMusicVolume(float f_musicVolumeSlider)
    {
        masterAudioMixer.SetFloat("MasterVolumeParameter", f_musicVolumeSlider);
        Debug.Log($"Music volume changed to {f_musicVolumeSlider}.");
    }
    public void SetGameplayVolume(float f_gameplayVolumeSlider)
    {
        masterAudioMixer.SetFloat("MasterVolumeParameter", f_gameplayVolumeSlider);
        Debug.Log($"Gameplay volume changed to {f_gameplayVolumeSlider}.");
    }
}
