using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//bug.Log ("test");
	}
	
	// Update is called once per frame
	void Update () {
		Transform monTransform = GetComponent<Transform> ();
		monTransform.Rotate (0, 2, 0);	}
}
