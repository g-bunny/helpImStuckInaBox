using UnityEngine;
using System.Collections;

public class activateObject : MonoBehaviour {
	public Transform player;
	public Transform interactionObject;
	public Transform interactionObject2;
	private float distance;
	private float distance2;
	private Animator doorAnim;
	bool open = false;
	bool glitch = false;
	// Use this for initialization
	void Start () {
		doorAnim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (player.transform.position, interactionObject.transform.position);
		if(Input.GetKeyDown(KeyCode.RightShift)){
			if(distance <= 3f && open == false){
				open = true;
				doorAnim.SetBool("isOpen", true);

			} else if (distance <=3f && open == true){
				open = false;
				doorAnim.SetBool("isOpen", false);

			}
		}

		distance2 = Vector3.Distance (player.transform.position, interactionObject2.transform.position);
		if(Input.GetKeyDown(KeyCode.Return)){
			if(distance2 >= 14f){
				glitch = true;
				//doorAnim.SetBool("isOpen", true);
				GameObject.Find("ZeroCam").GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
				
			} else if (distance2 <=14f){
				glitch = false;
				//doorAnim.SetBool("isOpen", false);
				GameObject.Find("ZeroCam").GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
			}
		}
		Debug.Log (distance2);
		Debug.Log (glitch);
	}
}
