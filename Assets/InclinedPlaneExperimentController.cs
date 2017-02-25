using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InclinedPlaneExperimentController : MonoBehaviour {

	public Rigidbody slidingCube;
	public Transform initialPosition;
	public Text currentSpeedText;

	void Update() {
		Debug.Log (this.GetComponent<Rigidbody> ().velocity.magnitude);
		this.currentSpeedText.text = "Current Speed: " + System.Math.Round(this.GetComponent<Rigidbody> ().velocity.magnitude, 1) + "m/s";
	}

	public void ResetExperiment() {
		Instantiate (this.slidingCube, this.initialPosition.position, this.initialPosition.rotation);
		Destroy (this.gameObject);
	}

}
