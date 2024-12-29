using UnityEngine;
using UnityEngine.UI;
public class SoundSettingsUI : MonoBehaviour
{
	public Slider musicVolumeSlider;
	public Slider SFXsVolumeSlider;

	private void Start()
	{
		musicVolumeSlider.value = SoundManager.Instance.musicSource.volume;

		musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);

		SFXsVolumeSlider.value = SoundManager.Instance.SFXsVolume;

		SFXsVolumeSlider.onValueChanged.AddListener(OnSFXsVolumeChanged);

	}

	private void OnMusicVolumeChanged( float value )
	{
		SoundManager.Instance.SetMusicVolume(value);
	}

	private void OnSFXsVolumeChanged( float value )
	{
		SoundManager.Instance.SetSoundEffectsVolume(value);
	}
}
