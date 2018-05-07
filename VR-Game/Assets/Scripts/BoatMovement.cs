using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoatMovement : MonoBehaviour {

	[SerializeField]
	NavMeshAgent _navMeshAgent;
    public Transform SpawnPoint;
    private List<GameObject> targets; // Contains the list of available targets
    public int maxCapacity; // Setting max capacity for different tiers of boats
    private int currentCapacity = 0;
    private int size; // Size of list
    private int i = 0;
	public static int score = 1;
	public static bool win = false;

    public void Start()
	{
		_navMeshAgent = this.GetComponent<NavMeshAgent>();
        targets = new List<GameObject>();
        
        // Find all current GameObjects with the tag "Person" so they know what to pick up
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Person"))
        {
            targets.Add(obj);
        }

        size = targets.Count;

        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to " + gameObject.name);
        }
        else
        {
            _navMeshAgent.destination = targets[i].transform.position;
        }

    }

    private void Update()
    {
        var distance = Vector3.Distance(targets[i].transform.position, gameObject.transform.position);

        // When the boat gets close to the target
        if (distance < 10 )
        {
            targets[i].SetActive(false);
            //Destroy(targets[i]);
            i++;
            currentCapacity++;
			score++;
            
            // If there are still people to rescue and the boat has not reached max capacity
            if (i < size && currentCapacity != maxCapacity)
            {
                _navMeshAgent.destination = targets[i].transform.position;
            }
            // If the boat is at max capacity or there are no more available targets, return to spawn point and despawn
            if (i == size || currentCapacity == maxCapacity)
            {
                _navMeshAgent.destination = SpawnPoint.position;
				if (Vector3.Distance(gameObject.transform.position, SpawnPoint.transform.position) < 20)
                {
					Debug.Log ("Win Conditions have been met");
					win = true;
                    Destroy(gameObject);
                }
            }
        }
		if (i == size) {
			win = true;
		}
		// Rescue units are destroyed when running into the tornado
		if (Vector3.Distance (gameObject.transform.position, TornadoMovement.tornadoPosition) < 10) {
			Debug.Log ("Rescue unit destroyed");
			Destroy (gameObject);
		}
    }

}
