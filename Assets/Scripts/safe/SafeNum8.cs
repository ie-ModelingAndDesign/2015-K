using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SafeNum8 : MonoBehaviour {
	
	public Text score;
	
	SafeNum569 safeNum569;
	
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	}
	
	public void Click ()
	{
		safeNum569 = GetComponent<SafeNum569>();
		
		if (safeNum569.count != 3)
		{
			FlagManager.Instance.flags [111] = false;
			FlagManager.Instance.flags [112] = false;
			FlagManager.Instance.flags [113] = false;
			FlagManager.Instance.flags [114] = false;
			FlagManager.Instance.flags [115] = false;
			FlagManager.Instance.flags [116] = false;
			safeNum569.count++;
		}
		
		else if (safeNum569.count == 3 && FlagManager.Instance.flags [116] == true && safeNum569.overcount != 4)
		{
			if (FlagManager.Instance.flags [113] == false)
			{
				score.text = "[ending BAD]\n";
				Debug.Log ("BAD");
			}

			if (FlagManager.Instance.flags [113] == true)
			{
				score.text = "[ending NORMAL]\n";
				Debug.Log ("NORMAL");
			}
		}
		
		
		else if (safeNum569.count == 3 && FlagManager.Instance.flags [116] == false && safeNum569.overcount != 4)
		{
			score.text = "数字が違うみたいだ。\n";
			
			FlagManager.Instance.flags [111] = false;
			FlagManager.Instance.flags [112] = false;
			FlagManager.Instance.flags [113] = false;
			FlagManager.Instance.flags [114] = false;
			FlagManager.Instance.flags [115] = false;
			FlagManager.Instance.flags [116] = false;
			
			safeNum569.count = 0;
			safeNum569.overcount++;
			
			GameObject gameObjectPlayer1 = this.transform.Find ("PlayerNormal").gameObject;
			GameObject gameObjectPlayer2 = this.transform.Find ("PlayerNaki").gameObject;
			GameObject gameObjectPlayer3 = this.transform.Find ("PlayerOdoroki").gameObject;
			GameObject gameObjectPlayer4 = this.transform.Find ("PlayerKyohu").gameObject;
			GameObject gameObjectPlayer5 = this.transform.Find ("PlayerWarai").gameObject;
			
			gameObjectPlayer1.SetActive (true);
			gameObjectPlayer2.SetActive (false);
			gameObjectPlayer3.SetActive (false);
			gameObjectPlayer4.SetActive (false);
			gameObjectPlayer5.SetActive (false);
			
			FlagManager.Instance.flags [9] = false;
			
			FlagManager.Instance.flags [8] = false;
			FlagManager.Instance.flags [18] = false;
			FlagManager.Instance.flags [106] = false;
			
			GameObject gameObjectsafe = this.transform.Find ("safe").gameObject;
			gameObjectsafe.SetActive (false);
		}
		
		else if (safeNum569.count == 3 && safeNum569.overcount == 4)
		{
			score.text = "go to bed ending\n";
		}
		
		else
		{
			FlagManager.Instance.flags [111] = false;
			FlagManager.Instance.flags [112] = false;
			FlagManager.Instance.flags [113] = false;
			FlagManager.Instance.flags [114] = false;
			FlagManager.Instance.flags [115] = false;
			FlagManager.Instance.flags [116] = false;
			safeNum569.count++;
		}
	}
}
