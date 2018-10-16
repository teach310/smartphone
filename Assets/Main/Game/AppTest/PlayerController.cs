using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] Sprite upImg;
	[SerializeField] Sprite leftImg;
	[SerializeField] Sprite downImg;
	[SerializeField] SpriteRenderer spriteRenderer;
	public float speed = 300f;

	int direction = -1;

	void Start(){
		UpdateView();
	}

	void Update(){
		InputKey();
		Move();
		UpdateView();
	}

	void InputKey(){
		direction = -1;
		if(Input.GetKey(KeyCode.DownArrow)){
			direction = 0;
		}

		if(Input.GetKey(KeyCode.UpArrow)){
			direction = 1;
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			direction = 2;
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			direction = 3;
		}
	}

	void Move(){
		var moveVec = Vector3.zero;

		switch(direction){
			case 0:
			moveVec = Vector3.down;
			break;
			case 1:
			moveVec = Vector3.up;
			break;
			case 2:
			moveVec = Vector3.left;
			break;
			case 3:
			moveVec = Vector3.right;
			break;
		}

		this.transform.position += moveVec * speed * Time.deltaTime;
	}

	void UpdateView(){
		switch(direction){
			case 0:
			default:
			spriteRenderer.sprite = downImg;
			spriteRenderer.flipX = false;
			break;
			case 1:
			spriteRenderer.sprite = upImg;
			spriteRenderer.flipX = false;
			break;
			case 2:
			spriteRenderer.sprite = leftImg;
			spriteRenderer.flipX = false;
			break;
			case 3:
			spriteRenderer.sprite = leftImg;
			spriteRenderer.flipX = true;
			break;
		}
	}
}
