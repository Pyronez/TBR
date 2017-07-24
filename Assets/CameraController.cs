﻿
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float panSpeed = 5f;
	public float panBorderThickness = 10f;
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if (Input.GetKey("w"))
		{
			
			pos.y += panSpeed * Time.deltaTime;
	}
		transform.position = pos;

	}
}
