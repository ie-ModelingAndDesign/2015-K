using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_MainC : MonoBehaviour {
	
	public Text score;
	
	void Start () {
	}
	
	// 22文字まで(全角・句読点含む)
	
	void Update () {
		if (FlagManager.Instance.flags[106] == true && FlagManager.Instance.flags [18] == true)
		{
			score.text = "真ん中の引き出しを開けた。";

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
				score.text = "中には、1枚の紙切れと金庫が入っている。\n紙切れには、青色の文字が書き連ねられている。";

				GameObject gameObjectKami9 = this.transform.Find ("Kami9PIC").gameObject; //aaaaaaaaaa
				gameObjectKami9.SetActive(true);

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
					score.text = "どうやら、正しい数字を入力しないと\n金庫を開けることはできないみたいだ。\nどうしようかな…";

					if (FlagManager.Instance.flags [125] == false)
					{
						WaitTime();
						
						if (FlagManager.Instance.flags [0] == true)
						{
							FlagManager.Instance.flags [125] = true;
							FlagManager.Instance.flags [101] = false;
						}
					}
					
					if (FlagManager.Instance.flags [125] == true)
					{
						score.text = "\n　(金庫のボタンを押して、解錠してみよう)";

						gameObject2.SetActive(false);
						gameObjectKami9.SetActive(false);

						GameObject gameObjectK1 = this.transform.Find ("safe").gameObject;
						gameObjectK1.SetActive(true);
						
						WaitTime();
						//FlagManager.Instance.flags [8] = false;
						//FlagManager.Instance.flags [18] = false;
						//FlagManager.Instance.flags [106] = false;

						FlagManager.Instance.flags[9] = true;
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