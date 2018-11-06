using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour {

	[SerializeField]
	private GameObject ScenesObject;

	private GameObject[] scenes;

	private GameObject currentScene = null;

	// Use this for initialization
	void Awake () {

		int i = 0;
		scenes = new GameObject[ScenesObject.transform.childCount];
		foreach (Transform child in ScenesObject.transform)
		{
			scenes[i] = child.gameObject;
			child.gameObject.SetActive(false);
			i++;
		}
		currentScene = scenes[0];
		SceneChange(scenes[0].transform.name);
	}

	//シーン遷移させる関数
	public void SceneChange(string scene_name){

		for(int i = 0; i < scenes.Length; i++){
			if(scenes[i].transform.name == scene_name){
				currentScene.SetActive(false);
				scenes[i].SetActive(true);
				currentScene = scenes[i];
			}
		}

	}

}
