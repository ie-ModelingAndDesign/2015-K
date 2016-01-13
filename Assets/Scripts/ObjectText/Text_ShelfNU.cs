using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_ShelfNU : MonoBehaviour {
	
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
		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [14] == true)
		{
			score.text = "本棚だ。たくさんの本が入っている。";
			
			
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
				score.text = "この本棚には昔から、\n絵本や小説など、色々な本が置いてあった。";
				
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
					score.text = "いつか全部読んでみたいな…";
					
					
					
					if (FlagManager.Instance.flags [123] == false)
					{
						WaitTime();
						
						if (FlagManager.Instance.flags [0] == true)
						{
							FlagManager.Instance.flags [123] = true;
							FlagManager.Instance.flags [101] = false;
						}
					}
					
					if (FlagManager.Instance.flags [123] == true)
					{
						score.text = "";
						
						WaitTime();
						FlagManager.Instance.flags [8] = false;
						FlagManager.Instance.flags [14] = false;
					}
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