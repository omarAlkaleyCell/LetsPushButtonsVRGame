using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
public class PostProcessingManager : MonoBehaviour
{
	private Bloom bloom; // Reference to the Bloom override
	[SerializeField]private Volume volume;
	[SerializeField] private Slider bloomSlider;

	private void Start()
	{
		if (volume != null && volume.profile.TryGet(out bloom))
		{
			bloomSlider.value = bloom.intensity.value;
			bloomSlider.onValueChanged.AddListener(SetBloomIntensity);
		}

	}

	public void SetBloomIntensity( float intensity )
	{
		if (bloom != null)
		{
			bloom.intensity.value = intensity*2; // Adjust Bloom Intensity
		}
	}
}
