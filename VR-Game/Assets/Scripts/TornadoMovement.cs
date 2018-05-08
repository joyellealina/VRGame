using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TornadoMovement : MonoBehaviour {

	public float timer;
	public int newTarget;
	public float speed;
	public NavMeshAgent nav;
	public Vector3 target;
	public static Vector3 tornadoPosition = new Vector3(100,0,100);

	void Start () {
		nav = gameObject.GetComponent<NavMeshAgent> ();
		createNewTarget ();

		//Enable for testing, sets tornado's first target to a civilian location
		//target = new Vector3 (-10, gameObject.transform.position.y, -37);
		//nav.SetDestination (target);
	}

	void Update () {
		tornadoPosition = gameObject.transform.position;
		nav.speed = speed;
		timer += Time.deltaTime;
		/*
		if(timer >= newTarget){
			createNewTarget ();
			timer = 0;
		}*/
		if (gameObject.transform.position.x == target.x && gameObject.transform.position.z == target.z) {
			createNewTarget ();
		}
	}

	void createNewTarget () {
		//float myX = gameObject.transform.position.x;
		//float myZ = gameObject.transform.position.z;

		float xPos = Random.Range (-63, 96);
		float zPos = Random.Range (-65, 86);

		target = new Vector3 (xPos, gameObject.transform.position.y, zPos);

		nav.SetDestination (target);
	}
}
