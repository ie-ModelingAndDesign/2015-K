using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_Desk : MonoBehaviour {

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
		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [16] == true)
		{
			score.text = "おばあちゃんがずっと使っていた長机だ。";
			
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
				score.text = "古い机なので、塗装は落ちていて、\n表面にはキズが目立つ。";
				
				if (FlagManager.Instance.flags [122] == false)
				{
					WaitTime();
					
					if (FlagManager.Instance.flags [0] == true)
					{
						FlagManager.Instance.flags [122] = true;
						FlagManager.Instance.flags [101] = false;
					}
				}
				
				if (FlagManager.Instance.flags [122] == true)
				{
					score.text = "";
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [16] = false;
				}
			}
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