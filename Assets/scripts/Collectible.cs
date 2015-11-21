using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {
	public static int collectCount;

	void Start () {
	}
	
	void Update () {
		Debug.Log(collectCount);
	}
	void OnTriggerEnter(Collider target)
	{
		if (target.gameObject.tag == "Player")
			Destroy(gameObject);
		collectCount +=1;
	}
}
