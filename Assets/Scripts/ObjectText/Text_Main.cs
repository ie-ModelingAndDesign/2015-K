using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_Main : MonoBehaviour {

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
		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [102] == false && FlagManager.Instance.flags [103] == false && FlagManager.Instance.flags [104] == false && FlagManager.Instance.flags [105] == false && FlagManager.Instance.flags [106] == false && FlagManager.Instance.flags [107] == false && FlagManager.Instance.flags [108] == false && FlagManager.Instance.flags [109] == false && FlagManager.Instance.flags [110] == false)
		{
			GameObject gameObject = this.transform.Find ("MainPIC").gameObject;
			gameObject.SetActive(true);

			score.text = "とても大きなタンスだ。\n全部で9個の引き出しが付いている。";
			
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
				score.text = "上下左右4つの引き出しには、\nそれぞれ不思議な記号が描かれている。";
				
				if (FlagManager.Instance.flags [122] == false)
				{
					WaitTime();
					
					if (FlagManager.Instance.flags [0] == true)
					{
						FlagManager.Instance.flags [122] = true;
						FlagManager.Instance.flags [101] = false;

						GameObject gameObjectB1 = this.transform.Find ("ButtonNW").gameObject;
						gameObjectB1.SetActive(true);
						GameObject gameObjectB2 = this.transform.Find ("ButtonN").gameObject;
						gameObjectB2.SetActive(true);
						GameObject gameObjectB3 = this.transform.Find ("ButtonNE").gameObject;
						gameObjectB3.SetActive(true);
						GameObject gameObjectB4 = this.transform.Find ("ButtonW").gameObject;
						gameObjectB4.SetActive(true);
						GameObject gameObjectB5 = this.transform.Find ("ButtonC").gameObject;
						gameObjectB5.SetActive(true);
						GameObject gameObjectB6 = this.transform.Find ("ButtonE").gameObject;
						gameObjectB6.SetActive(true);
						GameObject gameObjectB7 = this.transform.Find ("ButtonSW").gameObject;
						gameObjectB7.SetActive(true);
						GameObject gameObjectB8 = this.transform.Find ("ButtonS").gameObject;
						gameObjectB8.SetActive(true);
						GameObject gameObjectB9 = this.transform.Find ("ButtonSE").gameObject;
						gameObjectB9.SetActive(true);
					}
				}
				
				if (FlagManager.Instance.flags [122] == true)
				{
					score.text = "どこを調べようかな？";
					WaitTime();
				}
			}
		}
		
		else if (FlagManager.Instance.flags [10] == false && FlagManager.Instance.flags [11] == false && FlagManager.Instance.flags [12] == false && FlagManager.Instance.flags [13] == false && FlagManager.Instance.flags [14] == false && FlagManager.Instance.flags [15] == false && FlagManager.Instance.flags [16] == false && FlagManager.Instance.flags [17] == false && FlagManager.Instance.flags [18] == false && FlagManager.Instance.flags [19] == false)
		{
			FlagManager.Instance.flags [101] = false;
			FlagManager.Instance.flags [121] = false;
			FlagManager.Instance.flags [122] = false;
			FlagManager.Instance.flags [123] = false;
			FlagManager.Instance.flags [124] = false;
			FlagManager.Instance.flags [125] = false;
			FlagManager.Instance.flags [126] = false;
			FlagManager.Instance.flags [127] = false;
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