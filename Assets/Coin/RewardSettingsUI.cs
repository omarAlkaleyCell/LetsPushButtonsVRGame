using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardSettingsUI : MonoBehaviour
{
    [SerializeField] private RewardManager rewardManager;
    [SerializeField] Toggle enableReward;

    // Start is called before the first frame update
    void Start()
    {
        enableReward.isOn = rewardManager.EnableReward;
        enableReward.onValueChanged.AddListener(EnableReward);
    }

   private void EnableReward (bool isOn )
    {
		rewardManager.EnableReward = isOn;
	}
}
