using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnBoatMovement : MonoBehaviour {

    public GameObject Boat;

    public void Seek()
    {
        gameObject.GetComponent<BoatMovement>().enabled = true;
    }
    
}
