using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnBoatMovement : MonoBehaviour {

    public GameObject Boat;

	public void Start(){
		Boat.GetComponent<BoatMovement>().enabled = true;
	}

    public void Seek()
    {
        Boat.GetComponent<BoatMovement>().enabled = true;
    }
    
}
