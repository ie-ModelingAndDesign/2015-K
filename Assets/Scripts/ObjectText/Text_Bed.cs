using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_Bed : MonoBehaviour {

	public Text score;

	int bedd;

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
		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [11] == true && bedd != 7)
		{
			score.text = "私の使っているベッドだ。";

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
				score.text = "少し前までここで眠っていたので、\nちょっとだけあたたかい。";

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
					FlagManager.Instance.flags [11] = false;

					bedd++;
				}
			}
		}

		else if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [11] == true && bedd == 7)
		{
			Invoke ("wait",2.0f);
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

	void wait()
	{
		score.text = "なんで、食べ物を探すのに\nこんなに歩き回ってるんだろ…\nもう疲れた…寝よう…";
		
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
			score.text = "「……！」「………！！」\n(誰かが私を呼んでいる気がするけど…)\n(……気のせい…かな…)";
			
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
				
				FlagManager.Instance.flags [5] = true;
				WaitTime();
				FlagManager.Instance.flags [8] = false;
				FlagManager.Instance.flags [11] = false;
				
				Invoke ("aaaa",5.5f);
			}
		}
	}
	
	void aaaa()
	{
		Application.LoadLevel ("title");
	}

}