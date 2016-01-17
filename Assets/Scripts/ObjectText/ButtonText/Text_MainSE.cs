using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_MainSE : MonoBehaviour {
	
	public Text score;
	
	void Start () {
	}
	
	// 22文字まで(全角・句読点含む)
	
	void Update () {
		if (FlagManager.Instance.flags[110] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [80] == false)
		{
			score.text = "右下の引き出しを開けた。";

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
				score.text = "中には1本の鍵が入っている。\n持ち手が丸い形になっている古めの鍵だ…\nとりあえず持っておこうかな。";

                GameObject gameObjectKey1 = this.transform.Find ("Key1PIC").gameObject;
                gameObjectKey1.SetActive(true);

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

                    gameObjectKey1.SetActive(false);
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
                    FlagManager.Instance.flags [60] = true;
                    FlagManager.Instance.flags [80] = true;
					FlagManager.Instance.flags [110] = false;
				}
			}
		}

		if (FlagManager.Instance.flags[110] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [80] == true)
		{
			score.text = "右下の引き出しを開けた。";
			
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
				score.text = "丸い鍵の入っていた引き出しだ。\n今はもう、中は空っぽのようだ。";
				
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
					FlagManager.Instance.flags [110] = false;
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