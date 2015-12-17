using UnityEngine;
using System.Collections;
using System;
/// プロジェクト名/Assetsフォルダにプロジェクト名/Assets/Resourcesフォルダを生成し、
/// その中でプロジェクト名/Assets/Resources/textフォルダを生成しプロジェクト名/Assets/Resources/text/text.textを置く。
/// </remarks>
public class textestest : MonoBehaviour {

	public TextAsset stageTextAsset;
	public string stageData;

	void Start () {
		ReadTextData();
	}

	void Update () {
		ReadTextData();
	}

	void ReadTextData(){
		stageTextAsset = Resources.Load("text/textestest") as TextAsset;
	}
}
