using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

    public static AudioManager instance = null;

	// is called before Start
	void Awake () {

        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Adds an audio source for each sound in our sounds array
		foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

        }
	}

    void Start()
    {
        Play("Wind");
        Debug.Log("Start is being called.");
    }

    public void Play(string name)
    {
        //Find the sound in the sounds array where sounds.name is equal to the name
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound" + name + " not found");
            return;
        }

        if (PauseMenu.GameIsPaused)
        {
            s.source.pitch *= .5f;
        }
        s.source.Play();
    }
}

   
