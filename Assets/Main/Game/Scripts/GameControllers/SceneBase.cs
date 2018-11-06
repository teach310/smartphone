using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBase : MonoBehaviour {
	public string NextScene;
	private SceneChanger sceneChanger;

	void Awake () {

		sceneChanger = (SceneChanger)FindObjectOfType(typeof(SceneChanger));
	}

	//シーン遷移
	public virtual void GoNextScene(){

		sceneChanger.SceneChange(NextScene);

	}
}
