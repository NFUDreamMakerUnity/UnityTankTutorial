using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        GetComponent<TankMovementController>().MoveForward(-Input.GetAxis("Vertical"));
        GetComponent<TankMovementController>().Turn(Input.GetAxis("Horizontal"));

    }
}
