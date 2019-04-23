using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.AddressableAssets;
using UnityEngine.U2D;

public class PlayerTest : MonoBehaviour {

	// [AssetReferenceTypeRestriction(typeof(SpriteAtlas)),SerializeField]
	// AssetReference playerRef;

	// [SerializeField]  SpriteRenderer spRenderer;
	// private int currentDirection = 0;
	// private List<Sprite> directionSprites = new List<Sprite>();

	// enum direction{
	// 	UP = 0,
	// 	DOWN = 1,
	// 	LEFT = 2,
	// 	RIGHT = 3
	// };
	// direction DIRECTION;

	// void Start(){
		
	// 	Addressables.LoadAsset<SpriteAtlas>(playerRef).Completed += atlas => {
	// 		//spRenderer.sprite = atlas.Result.GetSprite(atlas.Result.name + "_" + direction.ToString());

	// 		for(int i = 0; i < 3; i++){
	// 			directionSprites.Add(atlas.Result.GetSprite(atlas.Result.name + "_" + i.ToString()));
	// 			Debug.Log(directionSprites[i]);
	// 		}
			
	// 	};
	// }

	// void Update(){

	// 	InputDirection();
	// 	UpdateDirection();
	// }

	// // void FixedUpdate(){

	// // }

	// private void InputDirection(){
		
	// 	if(Input.GetKey(KeyCode.DownArrow)){
	// 		currentDirection = 0;
	// 	}

	// 	if(Input.GetKey(KeyCode.UpArrow)){
	// 		currentDirection = 1;
	// 	}

	// 	if(Input.GetKey(KeyCode.LeftArrow)){
	// 		currentDirection = 2;
	// 	}

	// 	if(Input.GetKey(KeyCode.RightArrow)){
	// 		currentDirection = 3;
	// 	}
	// }

	// private void UpdateDirection(){
		
	// 	if(currentDirection == 3){
	// 		spRenderer.sprite = directionSprites[2];
	// 		spRenderer.flipX = true;
	// 	}
	// 	else{
	// 		spRenderer.sprite = directionSprites[currentDirection];
	// 		spRenderer.flipX = false;
	// 	}
	// }
}
