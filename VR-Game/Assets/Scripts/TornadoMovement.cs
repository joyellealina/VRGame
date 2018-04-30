using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TornadoMovement : MonoBehaviour {

	/*
	Vector3 startPosition = new Vector3 (81, 0, 58);
	Float roamRadius = 3F;

	void FreeRoam(){
		Vector3 randomDirection = Random.insideUnitSphere * roamRadius;
		randomDirection += startPosition;
		NavMeshHit hit;
		NavMesh.SamplePosition (randomDirection, out hit, roamRadius, 1);
		Vector3 finalPosition = hit.position;
		_nav.destination = finalPosition;
	}
	*/

	public float timer;
	public int newTarget;
	public float speed;
	public NavMeshAgent nav;
	public Vector3 target;

	void Start () {
		nav = gameObject.GetComponent<NavMeshAgent> ();
	}

	void Update () {
		nav.speed = speed;
		timer += Time.deltaTime;
		if(timer >= newTarget){
			createNewTarget ();
			timer = 0;
		}
	}

	void createNewTarget () {
		float myX = gameObject.transform.position.x;
		float myZ = gameObject.transform.position.z;

		float xPos = myX + Random.Range (myX - 20, myX + 20);
		float zPos = myZ + Random.Range (myZ - 20, myZ + 20);

		target = new Vector3 (xPos, gameObject.transform.position.y, zPos);

		nav.SetDestination (target);
	}
}
