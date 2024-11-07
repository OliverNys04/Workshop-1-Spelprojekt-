using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    public AudioClip[] musicClips;   
    private AudioSource audioSource;
    private int musicIndex = 0;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayTrack(musicIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        { 
            musicIndex = (musicIndex + 1) % musicClips.Length;
            PlayTrack(musicIndex);
        }

    }

    private void PlayTrack(int index)
    {
        audioSource.clip = musicClips[index];
        audioSource.Play();
    }

}
