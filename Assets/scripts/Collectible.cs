using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {
	public static int collectCount;
	public Transform player;
	public Transform chimney;
	//private Transform chimney = GameObject.Find("Chimney").GetComponent<Transform>();
	//Vector3 chimneyPos = chimney.localScale;
	void Start () {
		Vector3 chimneyScale = chimney.localScale;
		chimneyScale.x = 0.0f;
		chimney.localScale = chimneyScale;
	}
	
	void Update () {
		Debug.Log(collectCount);
		if (collectCount >= 5){
			//chimney.localScale.x = 1f;
		}
	}
	void OnTriggerEnter(Collider target)
	{
		if (target.gameObject.tag == "Player")
			Destroy(gameObject);
		collectCount +=1;
	}
}
