using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_StudyDesk : MonoBehaviour {
	
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
		if (FlagManager.Instance.flags [13] == true)
		{
			score.text = "学習机だ。";



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
				score.text = "昔おばあちゃんに買ってもらったものなので、\nとても愛着がある。";
				
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
					score.text = "引き出しには、学校の教科書が置いてある。\n教科書は開いていないので、まだまだきれい。";



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
                        FlagManager.Instance.flags [13] = false;
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