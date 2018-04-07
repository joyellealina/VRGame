using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Prefab;
	public GameObject Parent;
	public float Scale;

    public void create() {
		GameObject newObject = Instantiate (Prefab, SpawnPoint.position, SpawnPoint.rotation) as GameObject;
		newObject.transform.localScale = new Vector3 (Scale, Scale, Scale);
		newObject.transform.parent = Parent.transform;
	}

}
