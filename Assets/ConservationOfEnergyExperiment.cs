using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConservationOfEnergyExperiment : MonoBehaviour {

	private float firstVerticalSpeed = -1f;

	void OnCollisionEnter(Collision collision) {
		if (this.firstVerticalSpeed < 0) {
			this.firstVerticalSpeed = collision.relativeVelocity.y;
		}
		this.transform.GetComponent<Rigidbody> ().velocity = new Vector3(0, this.firstVerticalSpeed, 0);
	}

}
