using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_UG : MonoBehaviour {
	
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

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [19] == true && FlagManager.Instance.flags [85] == false)
		{
			score.text = "床に不自然なくぼみがある。\nつかんで持ち上げられそうだ。";
			
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
				score.text = "床板を引っ張ると、地下への階段が見つかった！\n階段の先は真っ暗だ…\n少しだけ入ってみようかな…";
				
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
					FlagManager.Instance.flags [19] = false;
					FlagManager.Instance.flags [85] = true;
					Application.LoadLevel ("UnderGround");
				}
			}
		}

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [19] == true && FlagManager.Instance.flags [85] == true)
		{
			score.text = "地下につづく階段だ。\n少しだけ入ってみようかな…";
			
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
				score.text = "";

				WaitTime();
				FlagManager.Instance.flags [8] = false;
				FlagManager.Instance.flags [19] = false;
				Application.LoadLevel ("UnderGround");
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