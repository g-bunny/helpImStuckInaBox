using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {
	public Transform hourHand;
	public Transform secondHand;
	public Transform minuteHand;
	// Use this for initialization
	float previousHr = 0;
	float previousMin = 0;
	float previousSec = 0;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		float hourRotationRate = 0.00833333333333333f * Time.deltaTime;
		float secRotationRate = 6f * Time.deltaTime;
		float minRotationRate = 0.1f * Time.deltaTime;


		previousHr += hourRotationRate;
		previousMin += minRotationRate;
		previousSec += secRotationRate;

		hourHand.localRotation = Quaternion.Euler (0f, 0f, previousHr);
		minuteHand.localRotation = Quaternion.Euler (0f, 0f, previousMin);
		secondHand.localRotation = Quaternion.Euler (0f, 0f, previousSec);
	}
}
