using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ToSafety : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    public GameObject FloodWater;
    public GameObject SafeLocation;
	public GameObject RescueLocation;
	public float timer = 0;

	public void Start()
	{
		_navMeshAgent = gameObject.GetComponent<NavMeshAgent> ();
	}

    public void MoveToSafety()
    {
        //if (FloodWater.activeSelf)
        //{
            gameObject.GetComponent<PersonPatrol>().enabled = false;
            _navMeshAgent.speed = 3.5f;
            _navMeshAgent.destination = SafeLocation.transform.position;
        //}
    }

	public void Update()
	{
		if (Vector3.Distance(gameObject.transform.position, SafeLocation.transform.position) < 1.5)
		{
			Debug.Log("Safe Location Reached");
			gameObject.transform.position = RescueLocation.transform.position;
			gameObject.transform.parent = RescueLocation.transform;
		}
		// Civilians are destroyed when running into the tornado
		if (Vector3.Distance (gameObject.transform.position, TornadoMovement.tornadoPosition) < 10) {
			Debug.Log ("Civilian has died");
			Destroy (transform.parent.gameObject);
			Destroy (gameObject);
		}
		// Player loses a resource point every ten seconds during acid rain
		if (ActivateAcidRain.acidRain == true) {
			timer += Time.deltaTime;
			if (timer > 10) {
				if (BoatMovement.score > 0) {
					BoatMovement.score--;
				}
				timer = 0;
			}
		}
	}
}