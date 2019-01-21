using System.Collections;
using System.Collections.Generic;
using CA2;
using UnityEngine;
using UnityEngine.UI;

namespace Wakame{

    public class Game : SceneBase {

		// [SerializeField]
		// private int _count=0;
		// [SerializeField]
		// private Text countdownText;

		// private bool isControl;

		// void Start(){
		// 	StartCoroutine(CountDown(_count));
		// }

		// private IEnumerator CountDown(int count) {  
		// 	countdownText.text = count.ToString();
		// 	isControl = false;
		// 	while(true){
		// 		yield return new WaitForSeconds (1f);
		// 		count--;

		// 		if(count>0){
		// 			countdownText.text = count.ToString();
		// 		}
		// 		else if(count==0){
		// 			countdownText.text = "Start";
		// 		}
		// 		else{
		// 			Destroy(countdownText.gameObject);
		// 			isControl = true;
		// 			yield break;
		// 		}

		// 		yield return null;

		// 	}
		// }  

        [SerializeField]
        GameObject tile;
        [SerializeField]
        GameObject canvas;

        public override void OnLoad(object options = null){
            CreateStage(1);
        }

        private void CreateStage(int stage_id){

            //ToDO:stage_idを元にマスターからデータをとる

            int[,] stage = {
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,30,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,30,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,30,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            };

            GameObject tile_clone;
            int base_x = -1008;
            int base_y = -160;
            int tile_size = 38;
			int count = 0;

            //ToDO:stageの幅を定数で指定する
            for(int j = 0; j < 30; j++){
                for(int i = 0; i < 30; i++){

					count++;

                    switch(stage[j,i]){

                        case 0:
                            tile_clone = Instantiate(tile,Vector3.zero,Quaternion.identity,canvas.transform) as GameObject;
                            tile_clone.GetComponent<RectTransform>().anchoredPosition = new Vector3 (base_x+i*tile_size, 0 + base_y-(j*tile_size), 0);
							tile_clone.name = count.ToString();
                        break;

                        case 1:
                            tile_clone = Instantiate(tile,Vector3.zero,Quaternion.identity,canvas.transform) as GameObject;
                            tile_clone.GetComponent<RectTransform>().anchoredPosition = new Vector3 (base_x+i*tile_size, 0 + base_y-(j*tile_size), 0);
                            tile_clone.GetComponent<BoxCollider2D>().enabled=false;
							tile_clone.name = count.ToString();
                        break;

                        case 30:
                            tile_clone = Instantiate(tile,Vector3.zero,Quaternion.identity,canvas.transform) as GameObject;
                            tile_clone.GetComponent<RectTransform>().anchoredPosition = new Vector3 (base_x+i*tile_size, 0 + base_y-(j*tile_size), 0);
                            tile_clone.GetComponent<BoxCollider2D>().enabled=false;
							tile_clone.name = count.ToString();
                        break;

                    }

                }
            }

        }

    }

}
