using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Prefab;
	public GameObject Parent;

    public void create() {
		GameObject newObject = Instantiate (Prefab, SpawnPoint.position, SpawnPoint.rotation) as GameObject;
		newObject.transform.localScale = new Vector3 (.2F, .2F, .2F);
		newObject.transform.parent = Parent.transform;
	}

}
