using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController1 : MonoBehaviour {

	public float Velocity;
	public float maxSpeed = 10f;
	bool facingRight = true;

	private Rigidbody rb;
	Animator anim;
	//GameObject gObject;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 1f;
	//public int incrementer;
	public bool isPlayer = false;
	private bool wasFalse;
	//Camera cam;

	void Start () {
		anim = GetComponent<Animator> ();
		// = UnityEngine.Camera;
		//gObject = GetComponent<GameObject>();

//		rb = GetComponent<Rigidbody> ();
//		count = 0;
//		SetCountText();
//		winText.text = "";
		if (isPlayer == false){
			transform.Find("OneCam").GetComponent<Camera>().enabled = false;
			//cam.SetActive(true);
		}
	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.LeftShift)){
			if (isPlayer == true){
				isPlayer = false;
			} else if (isPlayer == false){
				isPlayer = true;
			}
		}
		//if(GameObject.Find ("Zero").isPlayer == false){
		//	isPlayer = true;
		//}

		if (isPlayer == true){
			if (Input.GetKeyDown (KeyCode.Space)) {
				anim.SetBool ("Ground", false);
				GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce,0));
			}
			//GameObject.Find ("Main Camera").SetActive(true);
			GameObject.Find("OneCam").GetComponent<Camera>().enabled = true;
		}
		if (isPlayer == false){
//			GameObject.Find ("Main Camera").SetActive(false);
			GameObject.Find("OneCam").GetComponent<Camera>().enabled = false;
			//GameObject.Find ("One").SetActive(false);
		}

	}

	void FixedUpdate() {
		grounded = Physics.CheckSphere(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		if (isPlayer){
			float move = Input.GetAxis ("Horizontal") * .5f;
			float zMove = Input.GetAxis ("Vertical") * .5f;
			Vector3 movement = new Vector3 (move, 0, zMove);
			anim.SetFloat ("vSpeed", GetComponent<Rigidbody>().velocity.y);
		//CharacterController.speed = 3.0f;
			anim.SetFloat ("Velocity", move);
			anim.SetFloat ("zVel", zMove);
			GetComponent<Rigidbody>().velocity = new Vector3 (move * maxSpeed, GetComponent<Rigidbody>().velocity.y, zMove * maxSpeed);
		}
//		if (move > 0 && !facingRight) {
//			Flip ();
//		} else if (move < 0 && facingRight) {
//			Flip ();
//		}
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
//		rb.AddForce (movement * speed);
	}

//	void Flip(){
//		facingRight = !facingRight;
//		Vector3 theScale = transform.localScale;
//		theScale.x *= -1;
//		transform.localScale = theScale;
//	}

//	void OnTriggerEnter(Collider other) {
//		if (other.gameObject.CompareTag ("Pick Up")) {
//			other.gameObject.SetActive (false);
//			count = count + 1;
//			SetCountText();
//		}
//	}
//	void SetCountText() {
//		countText.text = "Count: " + count.ToString ();
//		if (count == 12) {
//			winText.text = "You Win!";
//		}
//	}
}