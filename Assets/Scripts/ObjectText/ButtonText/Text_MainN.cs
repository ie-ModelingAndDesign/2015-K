using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_MainN : MonoBehaviour {

	public Text score;
	
	void Start () {
	}
	
	// 22文字まで(全角・句読点含む)
	
	void Update () {
		if (FlagManager.Instance.flags[103] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [44] == false && FlagManager.Instance.flags [88] == false)
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
		
		if (FlagManager.Instance.flags[103] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [44] == true && FlagManager.Instance.flags [88] == false)
		{
			score.text = "鍵は鍵穴にぴったりはまった。\nこの引き出しの鍵だったみたいだ。";
			
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
				score.text = "また1枚の紙切れが入っている。\nエノマワリヲシラベロ…";
				
				GameObject gameObjectKami5 = this.transform.Find ("Kami5PIC").gameObject;
				gameObjectKami5.SetActive(true);

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
					
					gameObject2.SetActive(false);
					gameObjectKami5.SetActive(false);

					gameObjectPlayer1.SetActive(true);
					gameObjectPlayer2.SetActive(false);
					gameObjectPlayer3.SetActive(false);
					gameObjectPlayer4.SetActive(false);
					gameObjectPlayer5.SetActive(false);
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
					FlagManager.Instance.flags [67] = true;
					FlagManager.Instance.flags [88] = true;
					FlagManager.Instance.flags [103] = false;
				}
			}
		}
		
		if (FlagManager.Instance.flags[103] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [88] == true)
		{
			score.text = "三角形の鍵で開いた引き出しだ。\n他の引き出しと同様に、1枚の紙が入っていた。";
			
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
				score.text = "いつもの赤文字で問題が書かれている。\nこの筆跡は…\n昔亡くなったばあちゃんの字にそっくりだ。";
				
				GameObject gameObjectKami5 = this.transform.Find ("Kami5PIC").gameObject;
				gameObjectKami5.SetActive(true);

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
					
					gameObject2.SetActive(false);
					gameObjectKami5.SetActive(false);

					gameObjectPlayer1.SetActive(true);
					gameObjectPlayer2.SetActive(false);
					gameObjectPlayer3.SetActive(false);
					gameObjectPlayer4.SetActive(false);
					gameObjectPlayer5.SetActive(false);

					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
					FlagManager.Instance.flags [103] = false;

					FlagManager.Instance.flags [117] = true;
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
