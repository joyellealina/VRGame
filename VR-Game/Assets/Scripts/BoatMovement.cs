using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoatMovement : MonoBehaviour {

	[SerializeField]
	Transform _destination;

	NavMeshAgent _navMeshAgent;

	public void Seek()
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
