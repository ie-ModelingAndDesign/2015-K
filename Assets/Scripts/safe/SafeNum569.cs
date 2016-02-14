using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SafeNum569 : MonoBehaviour {

	public Text score;

	public int count;
	public int overcount;
	
	// Use this for initialization
	void Start ()
	{
		count = 0;
		overcount = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	}
	
	public void Click ()
	{
		if (count != 3)
		{
			FlagManager.Instance.flags [111] = false;
			FlagManager.Instance.flags [112] = false;
			FlagManager.Instance.flags [113] = false;
			FlagManager.Instance.flags [114] = false;
			FlagManager.Instance.flags [115] = false;
			FlagManager.Instance.flags [116] = false;
			FlagManager.Instance.flags [100] = false;
			count++;
		}

		else if (count == 3 && overcount != 4)
		{
			score.text = "数字が違うみたいだ。\n";

			FlagManager.Instance.flags [111] = false;
			FlagManager.Instance.flags [112] = false;
			FlagManager.Instance.flags [113] = false;
			FlagManager.Instance.flags [114] = false;
			FlagManager.Instance.flags [115] = false;
			FlagManager.Instance.flags [116] = false;
			FlagManager.Instance.flags [100] = false;

			count = 0;
			overcount++;

			GameObject gameObjectPlayer1 = this.transform.Find ("PlayerNormal").gameObject;
			GameObject gameObjectPlayer2 = this.transform.Find ("PlayerNaki").gameObject;
			GameObject gameObjectPlayer3 = this.transform.Find ("PlayerOdoroki").gameObject;
			GameObject gameObjectPlayer4 = this.transform.Find ("PlayerKyohu").gameObject;
			GameObject gameObjectPlayer5 = this.transform.Find ("PlayerWarai").gameObject;
			
			gameObjectPlayer1.SetActive (true);
			gameObjectPlayer2.SetActive (false);
			gameObjectPlayer3.SetActive (false);
			gameObjectPlayer4.SetActive (false);
			gameObjectPlayer5.SetActive (false);

			FlagManager.Instance.flags [9] = false;

			FlagManager.Instance.flags [8] = false;
			FlagManager.Instance.flags [18] = false;
			FlagManager.Instance.flags [106] = false;

			GameObject gameObjectsafe = this.transform.Find ("safe").gameObject;
			gameObjectsafe.SetActive (false);
		}

		else if (count == 3 && overcount == 4)
		{
			score.text = "そういえばお腹すいたな…\n全然、食べ物も見つからないし…\nだめだ…もう寝よう……";
			
			Debug.Log ("BAD");
			
			Invoke ("BAD",5.5f);

			FlagManager.Instance.flags [111] = false;
			FlagManager.Instance.flags [112] = false;
			FlagManager.Instance.flags [113] = false;
			FlagManager.Instance.flags [114] = false;
			FlagManager.Instance.flags [115] = false;
			FlagManager.Instance.flags [116] = false;
			FlagManager.Instance.flags [100] = false;
			
			count = 0;
			overcount++;
			
			GameObject gameObjectPlayer1 = this.transform.Find ("PlayerNormal").gameObject;
			GameObject gameObjectPlayer2 = this.transform.Find ("PlayerNaki").gameObject;
			GameObject gameObjectPlayer3 = this.transform.Find ("PlayerOdoroki").gameObject;
			GameObject gameObjectPlayer4 = this.transform.Find ("PlayerKyohu").gameObject;
			GameObject gameObjectPlayer5 = this.transform.Find ("PlayerWarai").gameObject;
			
			gameObjectPlayer1.SetActive (true);
			gameObjectPlayer2.SetActive (false);
			gameObjectPlayer3.SetActive (false);
			gameObjectPlayer4.SetActive (false);
			gameObjectPlayer5.SetActive (false);
			
			FlagManager.Instance.flags [9] = false;
			
			FlagManager.Instance.flags [8] = false;
			FlagManager.Instance.flags [18] = false;
			FlagManager.Instance.flags [106] = false;
			
			GameObject gameObjectsafe = this.transform.Find ("safe").gameObject;
			gameObjectsafe.SetActive (false);


		}
	}

	void BAD()
	{
		Application.LoadLevel ("maruti_end3");
	}
}
