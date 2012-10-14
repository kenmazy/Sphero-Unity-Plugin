using UnityEngine;
using System.Collections;

public class BlinkScript : MonoBehaviour {
	
	private int counter = 0;
	
	// Use this for initialization
	void Start () {
#if !UNITY_EDITOR
		RKUNBridge._RKUNSetupRobotConnection();
#endif
	}
	
	// Update is called once per frame
	void Update () {
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
}
