using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Test2 : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		float distToCube = (transform.position - Camera.main.transform.position).magnitude;

		if (Input.GetButton ("Fire1") && distToCube<3.0f)
			
			rb.AddForce (Camera.main.transform.forward * 100);

	}
}
