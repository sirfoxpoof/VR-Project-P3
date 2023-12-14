using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlayr : MonoBehaviour
{
    public AudioClip[] audioClips;

    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    public AudioClip GetRandomClip()
    {
        return audioClips[UnityEngine.Random.Range(0, audioClips.Length)];
    }

}
