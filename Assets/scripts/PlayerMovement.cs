using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
//	
//	public float Speed;
//	public float maxSpeed = 10f;
//	public Transform groundCheck;
//	public LayerMask whatIsGround;
//	public float jumpForce = 700f;
//	public float gravity = 9.8f;
//	
//	bool facingRight = true;
//	private Rigidbody playerRigidbody;
//	Animator anim;
//	bool grounded = false;
//	float groundRadius = 0.2f;
//	float camRayLength = 100f;
//	int floorMask;
//	
//	void Awake(){
//		floorMask = LayerMask.GetMask ("Floor");
//		anim = GetComponent<Animator> ();
//		playerRigidbody = GetComponent<Rigidbody>();
//	}
//	void Start () {
//		
//		//		rb = GetComponent<Rigidbody> ();
//		//		count = 0;
//		//		SetCountText();
//		//		winText.text = "";
//	}
//	
//	void Update() {
//		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
//			anim.SetBool ("Ground", false);
//			GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce,0));
//		}
//	}
//	
//	void FixedUpdate() {
//
//		float h = Input.GetAxisRaw ("Horizontal");
//		float v = Input.GetAxisRaw ("Vertical");
//		grounded = Physics.OverlapSphere (groundCheck.position, groundRadius, whatIsGround);
//		anim.SetBool ("Ground", grounded);
//		
//		
//		float move = Input.GetAxis ("Horizontal") * .5f;
//		Vector3 movement = new Vector3 (move, 0, 0);
//		anim.SetFloat ("vSpeed", GetComponent<Rigidbody>().velocity.y);
//		//CharacterController.speed = 3.0f;
//		anim.SetFloat ("Speed", Mathf.Abs (move));
//		GetComponent<Rigidbody>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody>().velocity.y);
//		if (move > 0 && !facingRight) {
//			Flip ();
//		} else if (move < 0 && facingRight) {
//			Flip ();
//		}
//		//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		//		float moveVertical = Input.GetAxis ("Vertical");
//		//		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
//		//		rb.AddForce (movement * speed);
//	}
//	
//	void Flip(){
//		facingRight = !facingRight;
//		Vector3 theScale = transform.localScale;
//		theScale.x *= -1;
//		transform.localScale = theScale;
//	}
//	
//	//	void OnTriggerEnter(Collider other) {
//	//		if (other.gameObject.CompareTag ("Pick Up")) {
//	//			other.gameObject.SetActive (false);
//	//			count = count + 1;
//	//			SetCountText();
//	//		}
//	//	}
//	//	void SetCountText() {
//	//		countText.text = "Count: " + count.ToString ();
//	//		if (count == 12) {
//	//			winText.text = "You Win!";
//	//		}
//	//	}
}