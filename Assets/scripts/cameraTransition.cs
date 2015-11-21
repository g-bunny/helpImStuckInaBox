//using UnityEngine;
//using System.Collections;
//
//public class cameraTransition : MonoBehaviour {
////	public CameraClearFlags clearFlags;
//	public Color normWhite = Color.white;
//	public Color blackout = Color.black;
//	public float duration = 2.0F;
//	public bool isActiveCam;
//	private bool camStable;
//	//public Rect rect;
//	Camera camera;
//
//	camera = GetComponent<Camera>();
//	Rect rect;
//	//public BackgroundColor backgroundColor;
//	void Start () {
//		//camera.clearFlags = CameraClearFlags.SolidColor;
//		Camera.backgroundColor = normWhite;
//	
//	}
//
//	void Update () {
//		if(Input.GetButtonDown (KeyCode.LeftShift)){
//			isActiveCam = !isActiveCam;
//			camStable = false;
//		}
//		if(isActiveCam == false && camStable == false){
//			fadeToBlack ();
//			camStable = true;
//		}
//	}
//
//	void fadeToBlack(){
//		//make sure clearFlags are SolidColor
//		float t = Mathf.PingPong(Time.time, duration) / duration;
//		Camera.backgroundColor = Color.Lerp (normWhite, blackout, t);
//		Camera.rect = Rect (0,0,0,0);
//	}
//
//	void fadeBackToFocus(){
//		float t = Mathf.PingPong(Time.time, duration) / duration;
//		Camera.backgroundColor = Color.Lerp(blackout, normWhite, t);
//		Camera.rect = Rect(0,1,0,1);
//	}
//}
