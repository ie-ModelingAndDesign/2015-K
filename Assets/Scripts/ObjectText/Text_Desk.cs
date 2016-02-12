using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_Desk : MonoBehaviour {

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
		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [16] == true && FlagManager.Instance.flags [89] == false && FlagManager.Instance.flags [90] == false)
		{
			score.text = "おばあちゃんがずっと使っていた長机だ。";
			
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
				score.text = "古い机なので、塗装は落ちていて、\n表面にはキズが目立つ。";
				
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
					FlagManager.Instance.flags [16] = false;
				}
			}
		}

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [16] == true && FlagManager.Instance.flags [89] == true && FlagManager.Instance.flags [90] == false)
		{
			score.text = "おばあちゃんがずっと使っていた長机だ。\n古い机なので、塗装は落ちていて、\n表面にはキズが目立つ。";
			
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
				score.text = "机上には、壁にかかっていた絵が置いてある。\n描かれているのは、優しい顔をした女の人だ。";
				
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
					score.text = "よく見てみると、絵と額縁のすき間に\n不自然なスペースが空いている。\n中の絵を取り外すことができそうだ。";
						
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
						score.text = "絵から額縁と底板を取り外すと、\n中から、さらに2枚の絵と鍵が見つかった。\n同じ絵…かな？";

						GameObject gameObjectPicPic = this.transform.Find ("PicturePIC").gameObject;
						gameObjectPicPic.SetActive(true);
						
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
							score.text = "例に漏れず紙切れも入っているので、\nこの紙だけは持っておこうかな。";

							GameObject gameObjectKami6 = this.transform.Find ("Kami6PIC").gameObject;
							gameObjectPicPic.SetActive(false);
							gameObjectKami6.SetActive(true);
							
							if (FlagManager.Instance.flags [125] == false)
							{
								WaitTime();
								
								if (FlagManager.Instance.flags [0] == true)
								{
									FlagManager.Instance.flags [125] = true;
									FlagManager.Instance.flags [101] = false;
								}
							}
							
							if (FlagManager.Instance.flags [125] == true)
							{
								score.text = "";

								gameObjectKami6.SetActive(false);
								
								WaitTime();
								FlagManager.Instance.flags [8] = false;
								FlagManager.Instance.flags [16] = false;
								FlagManager.Instance.flags [68] = true;
								FlagManager.Instance.flags [69] = true;
								FlagManager.Instance.flags [90] = true;
							}
						}
					}
				}
			}
		}

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags [16] == true && FlagManager.Instance.flags [89] == true && FlagManager.Instance.flags [90] == true)
		{
			score.text = "おばあちゃんがずっと使っていた長机だ。\n古い机なので、塗装は落ちていて、\n表面にはキズが目立つ。";
			
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
				score.text = "壁にかかっていた絵から出てきた、2枚の絵だ。\nこれと一緒に、紙切れも一枚入っていた。";

				GameObject gameObjectPicPic = this.transform.Find ("PicturePIC").gameObject;
				gameObjectPicPic.SetActive(true);
				
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

					gameObjectPicPic.SetActive(false);
					
					WaitTime();
					FlagManager.Instance.flags [8] = false;
					FlagManager.Instance.flags [16] = false;
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