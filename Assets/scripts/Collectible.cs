using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {
	public static int collectCount;
	public Transform player;
	private Transform chimney = GameObject.Find("Chimney").GetComponent<Transform>();
	Vector3 chimneyPos = chimney.localScale;
	void Start () {
		chimney.localScale.x = 0f;
	}
	
	void Update () {
		Debug.Log(collectCount);
		if (collectCount >= 4){
			chimney.localScale.x = 1f;
		}
	}
	void OnTriggerEnter(Collider target)
	{
		if (target.gameObject.tag == "Player")
			Destroy(gameObject);
		collectCount +=1;
	}
}
