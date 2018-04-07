using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawn : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Prefab;

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

    public void Create() {
		GameObject newObject = Instantiate (Prefab, SpawnPoint.position, SpawnPoint.rotation) as GameObject;
		newObject.transform.localScale = new Vector3 (.2F, .2F, .2F);
	}

    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to " + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }

}
