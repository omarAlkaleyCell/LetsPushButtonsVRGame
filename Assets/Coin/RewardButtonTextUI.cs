using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardButtonTextUI: MonoBehaviour
{
    [SerializeField] private RewardManager manager;
    [SerializeField] private Text textUI;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        textUI.text = counter.ToString();
    }

    public void UpdateText()
    {
		if (manager && manager.EnableReward)
		{
			IncrementText();
		}
		else
		{
			ResetText();
		}
	}

    public void IncrementText()
    {
		counter++;
		textUI.text = counter.ToString();
	}

    public void ResetText()
    {
        counter = 0;
        textUI.text = counter.ToString();
    }
}
