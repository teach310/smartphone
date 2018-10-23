using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour {

	[SerializeField]
	GameObject ScenesObject;

	GameObject[] scenes;

	// Use this for initialization
	void Awake () {

		int i = 0;
		foreach (Transform child in ScenesObject.transform)
		{
			scenes[i] = child.gameObject;
			Debug.Log(scenes[i]);
			i++;

			
		}

	}

}
