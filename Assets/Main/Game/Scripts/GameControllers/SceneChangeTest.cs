using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeTest : MonoBehaviour {

	public SceneChanger sceneChanger;

	string[] sceneNames = {"Main","Title","StageSelect"};

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){

			int rand = Random.Range(0,sceneNames.Length);

			sceneChanger.SceneChange(sceneNames[rand]);
		}
	}
}
