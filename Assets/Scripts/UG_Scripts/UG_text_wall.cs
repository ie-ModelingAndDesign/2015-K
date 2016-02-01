/*****
 * 
 * if this source cord use -> flag 25 ON , and UG_Button.cs flag 25 add 
 * 
 */

/***
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UG_text_wall : MonoBehaviour {

	public Text score;

	void Start () {
		FlagManager.Instance.flags [101] = false;
		FlagManager.Instance.flags [121] = false;
		FlagManager.Instance.flags [122] = false;
		FlagManager.Instance.flags [123] = false;
		FlagManager.Instance.flags [124] = false;
		FlagManager.Instance.flags [125] = false;
		FlagManager.Instance.flags [126] = false;
		FlagManager.Instance.flags [127] = false;
	}

	// 22文字まで(全角・句読点含む)

	void Update () {
		if (FlagManager.Instance.flags [21] == true)
		{
			score.text = "あれ？\nいつのまにか戻ってきたみたい";

			if (FlagManager.Instance.flags [121] == false)
			{
				WaitTime();
				
				if (FlagManager.Instance.flags [0] == true)
				{
					FlagManager.Instance.flags [121] = true;
					FlagManager.Instance.flags [101] = false;
				}
			}

			if (FlagManager.Instance.flags [121] == true)
			{
				score.text = "";

				WaitTime();
				FlagManager.Instance.flags [8] = false;
				FlagManager.Instance.flags [21] = false;
				FlagManager.Instance.flags [25] = false;
			}
		}

		else if (FlagManager.Instance.flags [21] == false && FlagManager.Instance.flags [22] == false && FlagManager.Instance.flags [23] == false && FlagManager.Instance.flags [24] == false)
		{
			FlagManager.Instance.flags [101] = false;
			FlagManager.Instance.flags [121] = false;
			FlagManager.Instance.flags [122] = false;
			FlagManager.Instance.flags [123] = false;
			FlagManager.Instance.flags [124] = false;
			FlagManager.Instance.flags [125] = false;
			FlagManager.Instance.flags [126] = false;
			FlagManager.Instance.flags [127] = false;
		}
	}

	void WaitTime()
	{
		if (FlagManager.Instance.flags [101] == false)
		{
			FlagManager.Instance.flags [0] = false;
			FlagManager.Instance.flags [101] = true;
		}
	}
	
}
***/