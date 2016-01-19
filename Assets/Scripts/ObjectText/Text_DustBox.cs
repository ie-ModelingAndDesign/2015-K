using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_DustBox : MonoBehaviour {

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
		if (FlagManager.Instance.flags [7] == false && FlagManager.Instance.flags [17] == true && FlagManager.Instance.flags [81] == false && FlagManager.Instance.flags [82] == false)
		{
			score.text = "ゴミ箱だ。\nゴミであふれていっぱいになっている。";
			
			if (FlagManager.Instance.flags [121] == false) {
				WaitTime ();
				
				if (FlagManager.Instance.flags [0] == true) {
					FlagManager.Instance.flags [121] = true;
					FlagManager.Instance.flags [101] = false;
				}
			}
			
			if (FlagManager.Instance.flags [121] == true) {
				score.text = "";

				WaitTime ();
				FlagManager.Instance.flags [8] = false;
				FlagManager.Instance.flags [17] = false;
			}
		}

		if (FlagManager.Instance.flags [7] == false && FlagManager.Instance.flags [17] == true && FlagManager.Instance.flags [81] == true && FlagManager.Instance.flags [82] == false) {
			if (FlagManager.Instance.flags [83] == false) {
				score.text = "ゴミ箱だ。\nゴミであふれていっぱいになっている。";
				
				if (FlagManager.Instance.flags [121] == false) {
					WaitTime ();
					
					if (FlagManager.Instance.flags [0] == true) {
						FlagManager.Instance.flags [121] = true;
						FlagManager.Instance.flags [101] = false;
					}
				}
				
				if (FlagManager.Instance.flags [121] == true) {
					score.text = "よくみると、ゴミ箱の中に\nさっきと似たような紙切れが入っている…\n一応保管しておこう。";
					
					GameObject gameObjectKami2 = this.transform.Find ("Kami2PIC").gameObject;
					gameObjectKami2.SetActive(true);
					
					if (FlagManager.Instance.flags [122] == false) {
						WaitTime ();
						
						if (FlagManager.Instance.flags [0] == true) {
							FlagManager.Instance.flags [122] = true;
							FlagManager.Instance.flags [101] = false;
						}
					}
					
					if (FlagManager.Instance.flags [122] == true) {
						score.text = "";
						
						gameObjectKami2.SetActive(false);
						
						WaitTime ();
						FlagManager.Instance.flags [8] = false;
						FlagManager.Instance.flags [17] = false;
						FlagManager.Instance.flags [62] = true;
						FlagManager.Instance.flags [82] = true;
					}
				}
			}

			if (FlagManager.Instance.flags [83] == true)
			{
				score.text = "ゴミ箱だ。\nゴミであふれていっぱいになっている。";
				
				if (FlagManager.Instance.flags [121] == false) {
					WaitTime ();
					
					if (FlagManager.Instance.flags [0] == true) {
						FlagManager.Instance.flags [121] = true;
						FlagManager.Instance.flags [101] = false;
					}
				}
				
				if (FlagManager.Instance.flags [121] == true) {
					score.text = "";
					
					WaitTime ();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [17] = false;
				}
			}
		}

		if (FlagManager.Instance.flags [7] == false && FlagManager.Instance.flags [17] == true && FlagManager.Instance.flags [81] == true && FlagManager.Instance.flags [82] == true)
		{
			score.text = "ゴミ箱だ。\nゴミであふれていっぱいになっている。";
			
			if (FlagManager.Instance.flags [121] == false) {
				WaitTime ();
				
				if (FlagManager.Instance.flags [0] == true) {
					FlagManager.Instance.flags [121] = true;
					FlagManager.Instance.flags [101] = false;
				}
			}
			
			if (FlagManager.Instance.flags [121] == true) {
				score.text = "謎の紙切れが入っていたんだっけ…\nどういう意味なのかな？";
				
				GameObject gameObjectKami2 = this.transform.Find ("Kami2PIC").gameObject;
				gameObjectKami2.SetActive(true);
				
				if (FlagManager.Instance.flags [122] == false) {
					WaitTime ();
					
					if (FlagManager.Instance.flags [0] == true) {
						FlagManager.Instance.flags [122] = true;
						FlagManager.Instance.flags [101] = false;
					}
				}
				
				if (FlagManager.Instance.flags [122] == true) {
					score.text = "";
					
					gameObjectKami2.SetActive(false);
					
					WaitTime ();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [17] = false;
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
