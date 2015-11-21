using UnityEngine;
using System.Collections;

public class gravityAttractor : MonoBehaviour {

	public float gravity = -10f;
	public void Attract(Transform body){
		Vector3 targetDirection = (body.position - transform.position).normalized;
		Vector3 bodyUp = body.up;
		body.rotation = Quaternion.FromToRotation (bodyUp, targetDirection) * body.rotation;
		body.GetComponent<Rigidbody>().AddForce(targetDirection * gravity);
	}
}
