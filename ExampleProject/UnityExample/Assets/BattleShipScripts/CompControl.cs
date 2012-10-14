using UnityEngine;
using System.Collections;

public class CompControl : MonoBehaviour {
	public GameObject mine;

	public float timeToSpawn;
	private float timer=0;
	
	// Update is called once per frame
	void Update () {
		if(timer<timeToSpawn)
			timer=+Time.deltaTime;
		else
		{
			timer=0;
			Instantiate(mine,new Vector3(Random.value,0,Random.value),Quaternion.identity);
		}
	
	}
}
