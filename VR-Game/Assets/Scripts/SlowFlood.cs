using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFlood : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (transform.position.y < 2)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 0.06F, Space.World);
        }
	}
}
