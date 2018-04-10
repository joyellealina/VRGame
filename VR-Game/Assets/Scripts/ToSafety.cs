using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ToSafety : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    public GameObject FloodWater;
    public Transform SafeLocation;

    public void MoveToSafety()
    {
        gameObject.GetComponent<PersonPatrol>().enabled = false;
        _navMeshAgent.speed = 3.5f;
        _navMeshAgent.destination = SafeLocation.position;
    }
}