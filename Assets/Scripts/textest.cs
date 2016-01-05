using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textest : MonoBehaviour {

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

	void Update () {
		if (FlagManager.Instance.flags [10] == true)
		{
			score.text = "出力テスト(ベッド 1)";

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
				score.text = "出力テスト(ベッド 2)";

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
					FlagManager.Instance.flags [10] = false;
				}
			}
		}

		else
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