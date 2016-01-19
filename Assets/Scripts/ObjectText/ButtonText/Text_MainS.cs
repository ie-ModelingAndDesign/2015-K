using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_MainS : MonoBehaviour {
	
	public Text score;
	
	void Start () {
	}
	
	// 22文字まで(全角・句読点含む)
	
	void Update () {
		if (FlagManager.Instance.flags[109] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [42] == false)
		{
			score.text = "下の引き出しは開かない…";

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
					FlagManager.Instance.flags [109] = false;
				}
			}
		}

		if (FlagManager.Instance.flags[109] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [42] == true && FlagManager.Instance.flags [81] == false)
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
				score.text = "中には時計と鍵、紙切れが入っている…\nどういうことだろう…";

                GameObject gameObjectKami1 = this.transform.Find ("Kami1PIC").gameObject;
                gameObjectKami1.SetActive(true);

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
                    gameObjectKami1.SetActive(false);
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
                    FlagManager.Instance.flags [61] = true;
					FlagManager.Instance.flags [63] = true;
                    FlagManager.Instance.flags [81] = true;
					FlagManager.Instance.flags [109] = false;
				}
			}
		}

		if (FlagManager.Instance.flags[109] == true && FlagManager.Instance.flags [18] == true && FlagManager.Instance.flags [42] == true && FlagManager.Instance.flags [81] == true)
		{
			score.text = "丸形の鍵で開いた引き出しだ。\nここには、紙切れと鍵と時計が入っていた。";
			
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
				score.text = "時計はデジタル式だ。\n電池はないので、時刻は示してくれていない。\n一緒に入っていたものと関係があるのかな…";
				
				GameObject gameObjectClock = this.transform.Find ("ClockPIC").gameObject;
				gameObjectClock.SetActive(true);
				
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
					gameObjectClock.SetActive(false);

					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [18] = false;
					FlagManager.Instance.flags [109] = false;
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