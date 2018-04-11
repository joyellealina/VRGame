using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	int speed = 2600;
	private float rotateSpeed = 0.5f;
	public Vector2 leftThumbstickPosition;
	public Vector2 rightThumbstickPosition;
	private Rigidbody rb;

	private void Awake() {
		rb = gameObject.GetComponent<Rigidbody> ();
	}

	void Update () {
		leftThumbstickPosition = OVRInput.Get (OVRInput.Axis2D.PrimaryThumbstick);
		rb.velocity = new Vector3 (leftThumbstickPosition.y, 0, -leftThumbstickPosition.x) * speed * Time.deltaTime;
		rightThumbstickPosition = OVRInput.Get (OVRInput.Axis2D.SecondaryThumbstick);
		rb.transform.Rotate(0,rotateSpeed * rightThumbstickPosition.x,0);
		if(OVRInput.Get(OVRInput.Button.Four)){
			rb.velocity = new Vector3 (0, 1, 0) * speed * Time.deltaTime;
		}
		if(OVRInput.Get(OVRInput.Button.Three)){
			rb.velocity = new Vector3 (0, -1, 0) * speed * Time.deltaTime;
		}
	}
}