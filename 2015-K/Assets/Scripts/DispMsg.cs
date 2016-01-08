using UnityEngine;
using System.Collections;

public class DispMsg : MonoBehaviour {

	// Use this for initialization
	void Start () {
	  
	}


	public static int lengthMsg;
	public static bool flgDisp = false;
	public static float waitTime = 0;
	
	float nextTime = 0;


	// Update is called once per frame
	void Update () {

		if (flgDisp == true) {
			if (Time.time > nextTime) {
				if (lengthMsg < dispMsg.Length) {
					lengthMsg ++;
				}
				nextTime = Time.time + 0.01f;
			}
			if (lengthMsg >= dispMsg.Length) {
				waitTime += Time.deltaTime;
				if (waitTime > dispMsg.Length / 4) {
					flgDisp = false;
				}
			}
		}
	}

		public GUIStyle msgWnd;
	    public static string dispMsg;
	    public static void dispMessage (string msg){
		   dispMsg = msg;
		   lengthMsg = 0;
		   flgDisp = true;
		   waitTime = 0;
		
	}

	 void OnGUI (){
		const float screenWidth = 1136;


		const float msgwWidth = 800;
		const float msgwHeight =  190;
		const float msgwPosX = (screenWidth - msgwWidth) / 2;
		const float msgwPosY =   390;

		float factorSize = Screen.width / screenWidth;

		float msgwX;
		float msgwY;
		float msgwW = msgwWidth * factorSize;
		float msgwH = msgwHeight * factorSize;

		GUIStyle myStyle = new GUIStyle ();
		myStyle.fontSize = (int)(30 * factorSize);


		if (flgDisp == true) {
			msgwX = msgwPosX * factorSize;
			msgwY = msgwPosY * factorSize;
			GUI.Box (new Rect (msgwX, msgwY, msgwW, msgwH), "ウインドウ", msgWnd);

			myStyle.normal.textColor = Color.black;

			msgwX = (msgwPosX + 22) * factorSize;
			msgwY = (msgwPosY + 22) * factorSize;
			GUI.Label (new Rect (msgwX, msgwY, msgwW, msgwH),dispMsg.
			           Substring (0,lengthMsg),myStyle);
			GUI.Label (new Rect (msgwX, msgwY, msgwW, msgwH), "メッセージ", myStyle);

			myStyle.normal.textColor = Color.white;

			msgwX = (msgwPosX + 20) * factorSize;
			msgwY = (msgwPosY + 20) * factorSize;
			GUI.Label (new Rect(msgwX, msgwY, msgwW, msgwH),dispMsg.
			           Substring(0,lengthMsg),myStyle);
		}
	}
}
