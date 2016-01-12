using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_Bed : MonoBehaviour {

	public Text score;

	void Start () {
	}
    
    // 22文字まで(全角・句読点含む)

	void Update () {
		if (FlagManager.Instance.flags [11] == true)
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
					FlagManager.Instance.flags [11] = false;
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