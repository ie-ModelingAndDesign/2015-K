using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_ShelfNU : MonoBehaviour {
	
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
		if (FlagManager.Instance.flags [7] == false && FlagManager.Instance.flags [14] == true && FlagManager.Instance.flags [83] == false && FlagManager.Instance.flags [84] == false)
		{
			score.text = "本棚だ。\n絵本や小説など、たくさんの本が入っている。\nいつか全部読んでみたいな…";
			
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
				FlagManager.Instance.flags [14] = false;
			}
		}
		
		if (FlagManager.Instance.flags [7] == false && FlagManager.Instance.flags [14] == true && FlagManager.Instance.flags [83] == true && FlagManager.Instance.flags [84] == false) {
				score.text = "本棚だ。\n絵本や小説など、たくさんの本が入っている。";
				
				if (FlagManager.Instance.flags [121] == false) {
					WaitTime ();
					
					if (FlagManager.Instance.flags [0] == true) {
						FlagManager.Instance.flags [121] = true;
						FlagManager.Instance.flags [101] = false;
					}
				}
				
				if (FlagManager.Instance.flags [121] == true) {
					score.text = "棚の上の方にある本の隙間から、\nまた紙切れが顔を覗かせている…\nよめない…";
					
					GameObject gameObjectKami4 = this.transform.Find ("Kami4PIC").gameObject;
					gameObjectKami4.SetActive(true);
					
					if (FlagManager.Instance.flags [122] == false) {
						WaitTime ();
						
						if (FlagManager.Instance.flags [0] == true) {
							FlagManager.Instance.flags [122] = true;
							FlagManager.Instance.flags [101] = false;
						}
					}
					
					if (FlagManager.Instance.flags [122] == true) {
						score.text = "";
						
						gameObjectKami4.SetActive(false);
						
						WaitTime ();
						FlagManager.Instance.flags [8] = false;
						FlagManager.Instance.flags [14] = false;
						FlagManager.Instance.flags [65] = true;
						FlagManager.Instance.flags [84] = true;
					}
				}
		}
		
		if (FlagManager.Instance.flags [7] == false && FlagManager.Instance.flags [14] == true && FlagManager.Instance.flags [83] == true && FlagManager.Instance.flags [84] == true)
		{
			score.text = "本棚だ。\n絵本や小説など、たくさんの本が入っている。\n棚の上から下へ、古い順に並んでいるみたい。";
			
			if (FlagManager.Instance.flags [121] == false) {
				WaitTime ();
				
				if (FlagManager.Instance.flags [0] == true) {
					FlagManager.Instance.flags [121] = true;
					FlagManager.Instance.flags [101] = false;
				}
			}
			
			if (FlagManager.Instance.flags [121] == true) {
				score.text = "上の棚から、この紙切れを見つけたんだっけ…\nうーん？";
				
				GameObject gameObjectKami4 = this.transform.Find ("Kami4PIC").gameObject;
				gameObjectKami4.SetActive(true);
				
				if (FlagManager.Instance.flags [122] == false) {
					WaitTime ();
					
					if (FlagManager.Instance.flags [0] == true) {
						FlagManager.Instance.flags [122] = true;
						FlagManager.Instance.flags [101] = false;
					}
				}
				
				if (FlagManager.Instance.flags [122] == true) {
					score.text = "";
					
					gameObjectKami4.SetActive(false);
					
					WaitTime ();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [14] = false;
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
