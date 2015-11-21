using UnityEngine;
using System.Collections;

public class rotateCamera : MonoBehaviour {
	public Transform coreWithCam;
	private bool
		goingUp = false,
		goingDown = false,
		goingRight = false,
		goingLeft = false;
	private float xAngle = 0f;
	private float yAngle = 0f;
	private float storedXAngle = 0f;
	private float storedYAngle = 0f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (xAngle);
		//Debug.Log (yAngle);
		if(Input.GetKeyDown(KeyCode.I)){
			goingUp = true;
		}
		if(Input.GetKeyDown(KeyCode.K)){
			goingDown = true;
		}
		if(Input.GetKeyDown(KeyCode.J)){
			goingLeft = true;
		}
		if(Input.GetKeyDown(KeyCode.L)){
			goingRight = true;
		}

		if(goingUp){
			xAngle += 45f * Time.deltaTime;
			rotate();
			if(storedXAngle == 0f || storedXAngle == 360f){
				if(xAngle >= 90f){
					xAngle = 90f;
					goingUp = false;
					storedXAngle = 90f;
				} else {rotate ();}
			} else if (storedXAngle == 90f){
				if(xAngle >= 180f){
					xAngle = 180f;
					goingUp = false;
					storedXAngle = 180f;
				}else {rotate ();}
			} else if (storedXAngle == 180f){
				if(xAngle >= 270f){
					xAngle = 270f;
					goingUp = false;
					storedXAngle = 270f;
				}else {rotate ();}
			} else if (storedXAngle == 270f){
				if(xAngle == 0f || xAngle >= 355f){
					xAngle = 0f;
					rotate ();
					goingUp = false;
					storedXAngle = 0f;
				}else {rotate ();}
			}
		}
		if(goingDown){
			xAngle -= 30f * Time.deltaTime;
			rotate();
			if(storedXAngle ==0f){
				xAngle -= 30f * Time.deltaTime;
				rotate();
				if(xAngle <= 270f){
							xAngle = 270f;
							goingDown = false;
							storedXAngle = 270f;
				}
			} else if (storedXAngle == 90f){
				if(xAngle <= 0f){
					xAngle = 0f;
					goingDown = false;
					storedXAngle = 0f;
				}else {rotate ();}
			} else if (storedXAngle == 180f){
				if(xAngle <= 90f){
						xAngle = 90f;
						goingDown = false;
						storedXAngle = 90f;
				}else {rotate ();}
			} else if (storedXAngle == 270f){
				if(xAngle <= 180f){
							xAngle = 180f;
							goingDown = false;
							storedXAngle = 180f;
				}else {rotate ();}
			}
		}
		if(goingLeft){
			yAngle += 30f * Time.deltaTime;
			rotate();
			if(storedYAngle ==0f){
				if(yAngle >= 90f){
					yAngle = 90f;
					goingLeft = false;
					storedYAngle = 90f;
				}
			} else if (storedYAngle == 90f){
				if(yAngle>=180f){
							yAngle = 180f;
							goingLeft = false;
							storedYAngle = 180f;
						}
			} else if (storedYAngle == 180f){
				if(yAngle>=270f){
							yAngle = 270f;
							goingLeft = false;
							storedYAngle = 270f;
						}
			} else if (storedYAngle == 270f){
				if(yAngle == 0f || yAngle >= 360f){
					yAngle = 0f;
					goingLeft = false;
					storedYAngle = 0f;
				}
			}

		}
		if(goingRight){
			yAngle -= 30f * Time.deltaTime;
			rotate();
			if(storedYAngle ==0f){
				if( yAngle != 0f && yAngle <= 270f){
					yAngle = 270f;
					goingRight = false;
					storedYAngle = 270f;
				}
			} else if (storedYAngle == 90f){
				if(yAngle <= 0f){
					yAngle = 0f;
					goingRight = false;
					storedYAngle = 0f;
				}
			} else if (storedYAngle == 180f){
				if(yAngle <= 90f){
					yAngle = 90f;
					goingRight = false;
					storedYAngle = 90f;
				}
			} else if (storedYAngle == 270f){
				if(yAngle <= 180f){
					yAngle = 180f;
					goingRight = false;
					storedYAngle = 180f;
				}
			}
		}
	}
	void rotate(){
		//xAngle = xAngle % 360f;
		//yAngle = yAngle % 360f;
		coreWithCam.localRotation = Quaternion.Euler (xAngle, yAngle, 0f);
	}
}
