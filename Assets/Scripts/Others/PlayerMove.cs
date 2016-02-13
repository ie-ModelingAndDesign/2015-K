using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour
{
	public float speed = 3;

	void Update()
	{
		float x = CrossPlatformInputManager.GetAxisRaw ("Horizontal");
		float y = CrossPlatformInputManager.GetAxisRaw ("Vertical");

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags[101] == false && FlagManager.Instance.flags[9] == false)
		{
			if (-0.5 <= x && x <= 0.5)
			{
				if (0.5 <= y)
				{
					Vector2 direction = new Vector2 (0, y).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
					FlagManager.Instance.flags[1] = true;
					FlagManager.Instance.flags[2] = false;
					FlagManager.Instance.flags[3] = false;
					FlagManager.Instance.flags[4] = false;
					Debug.Log ("N");
				}

				else if (y <= -0.5)
				{
					Vector2 direction = new Vector2 (0, y).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
					FlagManager.Instance.flags[1] = false;
					FlagManager.Instance.flags[2] = true;
					FlagManager.Instance.flags[3] = false;
					FlagManager.Instance.flags[4] = false;
					Debug.Log ("S");
				}

				else
				{
					Vector2 direction = new Vector2 (0, 0).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
				}
			}

			else if (-0.5 <= y && y <= 0.5)
			{
				if (x <= -0.5)
				{
					Vector2 direction = new Vector2 (x, 0).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
					FlagManager.Instance.flags[1] = false;
					FlagManager.Instance.flags[2] = false;
					FlagManager.Instance.flags[3] = true;
					FlagManager.Instance.flags[4] = false;
					Debug.Log ("W");
				}

				else if (0.5 <= x)
				{
					Vector2 direction = new Vector2 (x, 0).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
					FlagManager.Instance.flags[1] = false;
					FlagManager.Instance.flags[2] = false;
					FlagManager.Instance.flags[3] = false;
					FlagManager.Instance.flags[4] = true;
					Debug.Log ("E");
				}

				else
				{
					Vector2 direction = new Vector2 (0, 0).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
				}
			}

			else
			{
				Vector2 direction = new Vector2 (0, 0).normalized;
				GetComponent<Rigidbody2D>().velocity = direction * speed;
			}
		}

		else
		{
			Vector2 direction = new Vector2 (0, 0).normalized;
			GetComponent<Rigidbody2D>().velocity = direction * speed;
		}
	}
}