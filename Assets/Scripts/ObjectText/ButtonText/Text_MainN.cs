using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_MainN : MonoBehaviour {
	
	public Text score;
	
	void Start () {
	}
	
	// 22文字まで(全角・句読点含む)
	
	void Update () {
		if (FlagManager.Instance.flags[103] == true && FlagManager.Instance.flags [18] == true)
		{
			score.text = "上の引き出しは開かない…";

			GameObject gameObject = this.transform.Find ("MainPIC").gameObject;
			gameObject.SetActive(false);
			
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
				score.text = "鍵がかかっている。\n開けるには鍵が必要みたい…";
				
				if (FlagManager.Instance.flags [124] == false)
				{
					WaitTime();
					
					if (FlagManager.Instance.flags [0] == true)
					{
						FlagManager.Instance.flags [124] = true;
						FlagManager.Instance.flags [101] = false;
					}
				}
				
				if (FlagManager.Instance.flags [124] == true)
				{
					score.text = "";
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
					FlagManager.Instance.flags [103] = false;
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