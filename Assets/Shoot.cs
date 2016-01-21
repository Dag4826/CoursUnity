using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float TimeShoot=0.3f;
	public Transform prefabbullet;

	//Temps écoulé avant de pouvoir re-shooter.
	float timeElasedShoot = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timeElasedShoot = timeElasedShoot + Time.deltaTime;
		if (Input.GetButtonDown ("Fire1") && timeElasedShoot >=TimeShoot) {
			Transform b = GameObject.Instantiate (prefabbullet) as Transform;
			b.position = Camera.main.transform.position + Camera.main.transform.forward * 3;
			b.GetComponent<Rigidbody> ().AddForce (Camera.main.transform.forward * 100, ForceMode.Impulse);
			b.rotation = Camera.main.transform.rotation;
		
		}
	}
}
