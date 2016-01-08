using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UG_text_wall : MonoBehaviour {

	public Text score;

	void Start () {

	}

	// 22文字まで(全角・句読点含む)

	void Update () {
		if (FlagManager.Instance.flags [21] == true) {

			FlagManager.Instance.flags [101] = true;
			score.text = "あれ？\nいつのまにか戻ってきたみたい";

			if (FlagManager.Instance.flags [0] == true) {

				score.text = "";

				FlagManager.Instance.flags [0] = false;
				FlagManager.Instance.flags [21] = false;
				FlagManager.Instance.flags [101] = false;


			}
		}
	}

}