using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Prefab;
	public GameObject Parent;
	public GameObject Error;
	public float Scale;

    public void create() {
		if (BoatMovement.score > 0) {
			GameObject newObject = Instantiate (Prefab, Parent.transform.position, Parent.transform.rotation) as GameObject;
			newObject.transform.localScale = new Vector3 (Scale, Scale, Scale);
			newObject.transform.parent = Parent.transform;
			Parent.GetComponent<TurnOnBoatMovement> ().enabled = true;
			BoatMovement.score--;
		} 
		else {
			//UI = GameObject.Find ("Spawn Error");
			//Error.setActive(true);
			Error.GetComponent<Text>().enabled = true;
			Invoke ("disableText", 3f);
		}
	}

	void disableText(){
		Error.GetComponent<Text> ().enabled = false;
	}
}
