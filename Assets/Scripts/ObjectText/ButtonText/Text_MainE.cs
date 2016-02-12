using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_MainE : MonoBehaviour {
	
	public Text score;
	
	void Start () {
	}
	
	// 22文字まで(全角・句読点含む)
	
	void Update () {
		if (FlagManager.Instance.flags[107] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [45] == false && FlagManager.Instance.flags [91] == false)
		{
			score.text = "右の引き出しは開かない…";

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
					FlagManager.Instance.flags [107] = false;
				}
			}
		}

		if (FlagManager.Instance.flags[107] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [45] == true && FlagManager.Instance.flags [91] == false)
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
				score.text = "「(テキストはまだない)」と描かれている紙だ。\n(ヒントメッセージ1)\n(ヒントメッセージ2)";
				
				GameObject gameObjectKami7 = this.transform.Find ("Kami7PIC").gameObject;
				gameObjectKami7.SetActive(true);

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
					gameObjectKami7.SetActive(false);

					gameObjectPlayer1.SetActive(true);
					gameObjectPlayer2.SetActive(false);
					gameObjectPlayer3.SetActive(false);
					gameObjectPlayer4.SetActive(false);
					gameObjectPlayer5.SetActive(false);
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
					FlagManager.Instance.flags [70] = true;
					FlagManager.Instance.flags [91] = true;
					FlagManager.Instance.flags [107] = false;
				}
			}
		}

		if (FlagManager.Instance.flags[107] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [91] == true)
		{
			score.text = "星形の鍵で開いた引き出しだ。\nこれで、記号が描かれた引き出しは\n全部開けたことになる。";
			
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
				score.text = "ここにも、問題が書かれた紙切れが入っていた。\n……どういうことだろう？";
				
				GameObject gameObjectKami7 = this.transform.Find ("Kami7PIC").gameObject;
				gameObjectKami7.SetActive(true);

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
					gameObjectKami7.SetActive(false);

					gameObjectPlayer1.SetActive(true);
					gameObjectPlayer2.SetActive(false);
					gameObjectPlayer3.SetActive(false);
					gameObjectPlayer4.SetActive(false);
					gameObjectPlayer5.SetActive(false);
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
					FlagManager.Instance.flags [107] = false;
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