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
        if (distance < 7 )
        {
            targets[i].SetActive(false);
            // Destroy(targets[i]);
            i++;
            currentCapacity++;
            
            // If there are still people to rescue and the boat has not reached max capacity
            if (i < size && currentCapacity != maxCapacity)
            {
                _navMeshAgent.destination = targets[i].transform.position;
            }
            // If the boat is at max capacity or there are no more available targets, return to spawn point and despawn
            if (i == size || currentCapacity == maxCapacity)
            {
                _navMeshAgent.destination = SpawnPoint.position;
                if (gameObject.transform.position == SpawnPoint.position)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

}
