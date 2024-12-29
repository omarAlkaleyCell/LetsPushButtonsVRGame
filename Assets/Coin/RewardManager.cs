using UnityEngine;

public class RewardManager : MonoBehaviour
{
	[SerializeField] private bool enableReward;
	public bool EnableReward { get { return enableReward; } set { enableReward = value; } }

	[SerializeField] private GameObject rewardGameObject;
	[SerializeField] private AudioClip rewardSFXClip;
	public void RewardThePlayer(Transform objectTransform)
	{
		if (enableReward)
		{
			rewardGameObject.SetActive(true);
			ParticleSystem[] VFXs = rewardGameObject.GetComponentsInChildren<ParticleSystem>();
			rewardGameObject.transform.position = objectTransform.position + objectTransform.up;
			PlayVFX(VFXs);
			PlaySFX(SoundManager.Instance.SFXsVolume);
		}
	}

	private void PlayVFX( ParticleSystem[] particleSystems )
	{
		foreach (var particleSystem in particleSystems)
		{
			particleSystem.Play();
		}
	}

	private void PlaySFX( float volume )
	{
		AudioSource.PlayClipAtPoint(rewardSFXClip , rewardGameObject.transform.position , volume);
		AudioSource rewardGameObjectAudioSource = rewardGameObject.GetComponent<AudioSource>();
		rewardGameObjectAudioSource.Play();
		rewardGameObjectAudioSource.volume = volume;
	}
}
