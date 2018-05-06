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

	public void Start()
	{
		_navMeshAgent = gameObject.GetComponent<NavMeshAgent> ();
	}

    public void MoveToSafety()
    {
        if (FloodWater.activeSelf)
        {
            gameObject.GetComponent<PersonPatrol>().enabled = false;
            _navMeshAgent.speed = 3.5f;
            _navMeshAgent.destination = SafeLocation.transform.position;
        }
    }

	public void Update()
	{
		if (Vector3.Distance(gameObject.transform.position, SafeLocation.transform.position) < 1.5)
		{
			Debug.Log("Safe Location Reached");
			gameObject.transform.position = RescueLocation.transform.position;
			gameObject.transform.parent = RescueLocation.transform;
		}
	}
}