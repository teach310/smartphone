using System.Collections;
using System.Collections.Generic;
using CA2;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Wakame.Data;
using System.Linq;
using Wakame.Domain.Repository;

namespace Wakame{

    public class Game : CA2.SceneBase {

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

            StageDataManager.Instance.Load()
				.Subscribe(_=>{
					var stageData = StageDataRepository.FindById(1);
					Debug.Log(stageData.stages);
                    CreateStage(stageData.stages);
				});

            //ModelTile tile = ModelTile.CreateById(10);
            
        }

        private void CreateStage(int[,] _stage){

            GameObject tile_clone;
            int base_x = -500;
            int base_y = -160;
            int tile_size = 38;
			int count = 0;

            //ToDO:stageの幅を定数で指定する
            for(int j = 0; j < 15; j++){
                for(int i = 0; i < 15; i++){

					count++;

                    Debug.Log(_stage[j,i]);

                    switch(_stage[j,i]){

                        //壁
                        case 0:
                            tile_clone = Instantiate(tile,Vector3.zero,Quaternion.identity,canvas.transform) as GameObject;
                            tile_clone.GetComponent<RectTransform>().anchoredPosition = new Vector3 (base_x+i*tile_size, 0 + base_y-(j*tile_size), 0);
							tile_clone.name = count.ToString();
                        break;

                        //道
                        case 10:
                            tile_clone = Instantiate(tile,Vector3.zero,Quaternion.identity,canvas.transform) as GameObject;
                            tile_clone.GetComponent<RectTransform>().anchoredPosition = new Vector3 (base_x+i*tile_size, 0 + base_y-(j*tile_size), 0);
                            tile_clone.GetComponent<BoxCollider2D>().enabled=false;
							tile_clone.name = count.ToString();
                        break;

                        //初期敵配置　道
                        case 15:
                            tile_clone = Instantiate(tile,Vector3.zero,Quaternion.identity,canvas.transform) as GameObject;
                            tile_clone.GetComponent<RectTransform>().anchoredPosition = new Vector3 (base_x+i*tile_size, 0 + base_y-(j*tile_size), 0);
                            tile_clone.GetComponent<BoxCollider2D>().enabled=false;
							tile_clone.name = count.ToString();
                        break;

                        //初期アイテムランダム配置　アイテム出現ポイント　道
                        case 21:
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
