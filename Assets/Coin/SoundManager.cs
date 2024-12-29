using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

	[Header("Audio Sources")]
	public AudioSource musicSource;
	public float SFXsVolume;

	void Awake()
    {
        if(Instance == null) 
        {
          Instance = this;
          DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	// Adjust volume levels
	public void SetMusicVolume( float volume )
	{
		musicSource.volume = volume;
	}

	public void SetSoundEffectsVolume( float volume )
	{
		SFXsVolume = volume;
	}
}
