using UnityEngine;
using System.Collections;

public class Item_Kami2 : MonoBehaviour {
	
		// Use this for initialization
		void Start () {

		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		public void Click () {
			
			GameObject gameObject = this.transform.Find ("kami2_x").gameObject; 
			
			if (FlagManager.Instance.flags [7] == false && FlagManager.Instance.flags [8] == false) {
				FlagManager.Instance.flags [40] = false;
				FlagManager.Instance.flags [41] = false;
				FlagManager.Instance.flags [42] = false;
				FlagManager.Instance.flags [43] = false;
				FlagManager.Instance.flags [44] = false;
				FlagManager.Instance.flags [45] = false;
				FlagManager.Instance.flags [46] = false;
				FlagManager.Instance.flags [47] = true;
				FlagManager.Instance.flags [48] = false;
				FlagManager.Instance.flags [49] = false;
				FlagManager.Instance.flags [50] = false;
				FlagManager.Instance.flags [51] = false;
				FlagManager.Instance.flags [52] = false;
				FlagManager.Instance.flags [53] = false;
				FlagManager.Instance.flags [54] = false;
				FlagManager.Instance.flags [55] = false;
				FlagManager.Instance.flags [7] = true;
				gameObject.SetActive(true);

				GameObject gameObjectA = this.transform.Find ("TextKami2").gameObject;
				gameObjectA.SetActive(true);
			}
		}
	}
