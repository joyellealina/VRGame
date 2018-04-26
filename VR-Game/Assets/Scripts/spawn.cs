using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Prefab;
	public GameObject Parent;
	public GameObject Error1;
	public GameObject Error2;
	public float Scale;
	public GameObject Water;

    public void create() {
		Debug.Log(Water.transform.position.y);
		if (Water.transform.position.y < 0.4) {
			Error2.GetComponent<Text> ().enabled = true;
			Invoke ("disableText", 3f);
		} else {
			if (BoatMovement.score > 0) {
				GameObject newObject = Instantiate (Prefab, Parent.transform.position, Parent.transform.rotation) as GameObject;
				newObject.transform.localScale = new Vector3 (Scale, Scale, Scale);
				newObject.transform.parent = Parent.transform;
				Parent.GetComponent<TurnOnBoatMovement> ().enabled = true;
				BoatMovement.score--;
			} else {
				Error1.GetComponent<Text> ().enabled = true;
				Invoke ("disableText", 3f);
			}
		}
	}

	void disableText(){
		Error1.GetComponent<Text> ().enabled = false;
		Error2.GetComponent<Text> ().enabled = false;
	}
}
