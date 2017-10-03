using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovementController : MonoBehaviour {

	[SerializeField]
    float Power = 1000;
    [SerializeField]
    GameObject WheelL;
    [SerializeField]
    GameObject WheelR;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawLine(WheelL.transform.position, WheelL.transform.forward * Power, Color.blue);

    }
    public void MoveForward(float forward)
    {
        GetComponent<Rigidbody>().AddForceAtPosition(forward * WheelL.transform.forward * Power, WheelL.transform.position);
        GetComponent<Rigidbody>().AddForceAtPosition(forward * WheelR.transform.forward * Power, WheelR.transform.position);
        
    }

        public void Turn(float Turn)
    {
        GetComponent<Rigidbody>().AddForceAtPosition(-Turn * WheelL.transform.forward * Power, WheelL.transform.position);
        GetComponent<Rigidbody>().AddForceAtPosition(Turn * WheelR.transform.forward * Power, WheelR.transform.position);
        
    }
}
