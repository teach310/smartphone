using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : SceneBase {

	[SerializeField]
	private int _count=0;
	[SerializeField]
	private Text countdownText;

	private bool isControl;

	void Start(){
		StartCoroutine(CountDown(_count));
	}

	private IEnumerator CountDown(int count) {  
		countdownText.text = count.ToString();
		isControl = false;
        while(true){
			 yield return new WaitForSeconds (1f);
			 count--;

			 if(count>0){
				 countdownText.text = count.ToString();
			 }
			 else if(count==0){
				 countdownText.text = "Start";
			 }
			 else{
				Destroy(countdownText.gameObject);
				isControl = true;
				yield break;
			 }

			 yield return null;

		}
    }  

}
