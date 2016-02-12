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
			GameObject gameObject2 = this.transform.Find ("MainPIC2").gameObject;
			gameObject2.SetActive(true);
			
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

				GameObject gameObjectPlayer1 = this.transform.Find ("PlayerNormal").gameObject;
				GameObject gameObjectPlayer2 = this.transform.Find ("PlayerNaki").gameObject;
				GameObject gameObjectPlayer3 = this.transform.Find ("PlayerOdoroki").gameObject;
				GameObject gameObjectPlayer4 = this.transform.Find ("PlayerKyohu").gameObject;
				GameObject gameObjectPlayer5 = this.transform.Find ("PlayerWarai").gameObject;

				gameObjectPlayer1.SetActive(false);
				gameObjectPlayer2.SetActive(true);
				gameObjectPlayer3.SetActive(false);
				gameObjectPlayer4.SetActive(false);
				gameObjectPlayer5.SetActive(false);


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
					gameObject2.SetActive(false);

					gameObjectPlayer1.SetActive(true);
					gameObjectPlayer2.SetActive(false);
					gameObjectPlayer3.SetActive(false);
					gameObjectPlayer4.SetActive(false);
					gameObjectPlayer5.SetActive(false);
					
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
			GameObject gameObject2 = this.transform.Find ("MainPIC2").gameObject;
			gameObject2.SetActive(true);
			
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

					gameObject2.SetActive(false);
					
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