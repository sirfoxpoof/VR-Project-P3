using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumeSet : MonoBehaviour
{
    [SerializeField]
    private AudioMixer volumeMixer;
    private Slider masterSlider, musicSlider, sfxSlider;

    public void SetMasterVolume(float sliderValue)
    {
        volumeMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolumeSave", masterSlider.value);
    }

    public void SetMusicVolume(float sliderValue)
    {
        volumeMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolumeSave", musicSlider.value);
    }


    public void SetSFXVolume(float sliderValue)
    {
        volumeMixer.SetFloat("SoundEffectVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolumeSave", sfxSlider.value);
    }



}
