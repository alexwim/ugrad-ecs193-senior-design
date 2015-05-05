﻿using UnityEngine;
using System.Collections;
using VRWidgets;

public class StartButton : ButtonBase {
	private GameManager gameManager;

	void Start() {
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	public void Reset() {
		Rigidbody body = GetComponent<Rigidbody> ();
		body.velocity = Vector3.zero;
		body.angularVelocity = Vector3.zero;
		body.inertiaTensorRotation = Quaternion.identity;

		transform.localPosition = new Vector3 (0, 1, 0);
		transform.localRotation = new Quaternion(0.7f,0,0,0.7f);
	}

	public override void ButtonPressed() {
		Debug.Log("Start button pressed");
		gameManager.StartGame ();
	}

	public override void ButtonReleased() {
	}
}
