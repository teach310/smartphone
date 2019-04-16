using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wakame{
	public class PlayerController : MonoBehaviour {

		[SerializeField] SpriteRenderer spriteRenderer;
		public float speed = 300f;

		int current_direction = -1;
		enum Direction{
			RIGHT = 0,
			LEFT = 1,
			TOP = 2,
			DOWN = 3,
		}
		Direction direction = Direction.RIGHT;

		void Start(){
			UpdateView();
		}

		void Update(){
			InputKey();
			Move();
			UpdateView();
		}

		void InputKey(){
			current_direction = -1;
			if(Input.GetKey(KeyCode.DownArrow)){
				current_direction = 0;
				direction = Direction.DOWN;
			}

			if(Input.GetKey(KeyCode.UpArrow)){
				current_direction = 1;
				direction = Direction.TOP;
			}

			if(Input.GetKey(KeyCode.LeftArrow)){
				current_direction = 2;
				direction = Direction.LEFT;
			}

			if(Input.GetKey(KeyCode.RightArrow)){
				current_direction = 3;
				direction = Direction.RIGHT;
			}
		}

		void Move(){
			var moveVec = Vector3.zero;

			switch(current_direction){
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

				case Direction.TOP:
				spriteRenderer.flipY = false;
				break;

				case Direction.DOWN:
				spriteRenderer.flipY = true;
				break;

				case Direction.RIGHT:
				spriteRenderer.flipX = true;
				break;

				case Direction.LEFT:
				spriteRenderer.flipX = false;
				break;

				default:
				break;

			}
		}
	}
}