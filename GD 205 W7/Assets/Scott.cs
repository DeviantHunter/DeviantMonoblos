using UnityEngine;
using System.Collections;

public class Scott : MonoBehaviour {

	public float scottStrength = 1000f;
	public AudioClip ExplosionSound;
	public GameObject Blueprint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray beam = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (beam.origin, beam.direction * 1000f, Color.red);

		RaycastHit beamHit = new RaycastHit ();

		if (Physics.Raycast (beam, out beamHit, 1000f)) {
			Debug.Log ("hit?");
			if (beamHit.rigidbody) {
				Debug.Log ("has rigidbody");
				beamHit.rigidbody.AddForce ((Random.insideUnitSphere) * scottStrength);
				beamHit.collider.gameObject.gameObject.GetComponent<AudioSource> ().PlayOneShot (ExplosionSound);
			}
			if (Input.GetMouseButtonDown (1)) {
				Instantiate (Blueprint, beamHit.point, Quaternion.identity);
			}
		}
}
}