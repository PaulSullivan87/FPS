using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	public float tumble;
	
	void Start ()
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble; 
	}
}
