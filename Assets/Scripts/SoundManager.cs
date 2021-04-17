using UnityEngine.Audio;
using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public Sound[] sounds;
    public static SoundManager instance;
    // Start is called before the first frame update
    void Awake()
    {
         
        DontDestroyOnLoad(gameObject);
        foreach(Sound sound in sounds)
        {
          sound.audioSource  = gameObject.AddComponent<AudioSource>();
            sound.audioSource.clip = sound.clip;
            sound.audioSource.volume = sound.volume;
            sound.audioSource.pitch = sound.pitch;
            sound.audioSource.loop = sound.loop;
        }
    }
     void Start()
    {
        Play("Theme");
    }

    public void Play (string name){

        Sound sound = Array.Find(sounds, sound => sound.name == name);
        if (sound == null)
        {
            Debug.LogWarning("Sound:" + name + "bulunamadı!");
            return;
        }
        sound.audioSource.Play();

    }
}
