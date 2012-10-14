using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	public GameObject ship;

	// Use this for initialization
	void Start () {
		ship=GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
/*		if(Vector3.Magnitude(gameObject.transform.position-ship.transform.position))
		{
			#if !UNITY_EDITOR
		//Make Sphero change color every 30 frames
		if(counter == 0) {
			RKUNBridge._RKUNRGB(1.0f, 0.0f, 0.0f);	
		} else if(counter == 30) {
			RKUNBridge._RKUNRGB(0.0f, 1.0f, 0.0f);	
		} else if(counter == 60) {
			RKUNBridge._RKUNRGB(0.0f, 0.0f, 1.0f);	
		}
		counter++;
		if(counter==90) counter = 0;
		#endif
		}
*/	
	}
}
