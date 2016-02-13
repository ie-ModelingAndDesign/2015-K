using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_Picture : MonoBehaviour {

	public Text score;
	int i;
	
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
		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [15] == true && FlagManager.Instance.flags [88] == false && FlagManager.Instance.flags [89] == false)
		{
			score.text = "壁に絵がかかっている。";
			
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
				score.text = "絵にはきれいな女の人が描かれている。\nだれだろう？";
				
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
					FlagManager.Instance.flags [15] = false;
				}
			}
		}

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [15] == true && FlagManager.Instance.flags [88] == true && FlagManager.Instance.flags [89] == false && i < 5)
		{
			score.text = "壁に絵がかかっている。調べてみよう。";
			
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
				score.text = "………………。\n絵のまわりを調べたけど、何も見当たらない。\nもっとよく探してみようかな？";
				
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
					FlagManager.Instance.flags [15] = false;
					i = i + 1;
				}
			}
		}

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [15] == true && FlagManager.Instance.flags [88] == true && FlagManager.Instance.flags [89] == false && i == 5)
		{
			score.text = "壁に絵がかかっている。調べてみよう。";
			
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
				score.text = "………………。\n調べている途中で、絵を落としてしまった！\n危ないから長机に運んでおこう。";

				GameObject gameObjectPlayer1 = this.transform.Find ("PlayerNormal").gameObject;
				GameObject gameObjectPlayer2 = this.transform.Find ("PlayerNaki").gameObject;
				GameObject gameObjectPlayer3 = this.transform.Find ("PlayerOdoroki").gameObject;
				GameObject gameObjectPlayer4 = this.transform.Find ("PlayerKyohu").gameObject;
				GameObject gameObjectPlayer5 = this.transform.Find ("PlayerWarai").gameObject;
				
				gameObjectPlayer1.SetActive(false);
				gameObjectPlayer2.SetActive(false);
				gameObjectPlayer3.SetActive(true);
				gameObjectPlayer4.SetActive(false);
				gameObjectPlayer5.SetActive(false);
				
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

					gameObjectPlayer1.SetActive(true);
					gameObjectPlayer2.SetActive(false);
					gameObjectPlayer3.SetActive(false);
					gameObjectPlayer4.SetActive(false);
					gameObjectPlayer5.SetActive(false);
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [15] = false;
					FlagManager.Instance.flags [89] = true;
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