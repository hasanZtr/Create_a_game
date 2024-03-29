using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour {

	Vector3 velocity;
	Rigidbody myRigidbody;

	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}

	public void Move(Vector3 _velocity) {
		velocity = _velocity;
	}

	public void LookAt(Vector3 hitPoint) {
		Vector3 target = new Vector3 (hitPoint.x, transform.position.y, hitPoint.z);
		transform.LookAt (target);
	}

	public void FixedUpdate() {
		myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);

	}
}