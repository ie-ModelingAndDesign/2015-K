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

		if (FlagManager.Instance.flags[7] == false && FlagManager.Instance.flags[101] == false)
		{
			if (-0.3 <= x && x <= 0.3)
			{
				if (0.3 <= y)
				{
					Vector2 direction = new Vector2 (0, y).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
					FlagManager.Instance.flags[1] = true;
					FlagManager.Instance.flags[2] = false;
					FlagManager.Instance.flags[3] = false;
					FlagManager.Instance.flags[4] = false;
					Debug.Log ("N");
				}

				else if (y <= -0.3)
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

			else if (-0.3 <= y && y <= 0.3)
			{
				if (x <= -0.3)
				{
					Vector2 direction = new Vector2 (x, 0).normalized;
					GetComponent<Rigidbody2D>().velocity = direction * speed;
					FlagManager.Instance.flags[1] = false;
					FlagManager.Instance.flags[2] = false;
					FlagManager.Instance.flags[3] = true;
					FlagManager.Instance.flags[4] = false;
					Debug.Log ("W");
				}

				else if (0.3 <= x)
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