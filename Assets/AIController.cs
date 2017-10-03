using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour {
    GameObject Player;
    Vector3 CurrentPathPosition;
    TankMovementController tankMovementController;

    // Use this for initialization
    void Start () {
        tankMovementController = GetComponent<TankMovementController>();
        Player = FindObjectOfType<PlayerController>().gameObject;
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 Direction = (Player.transform.position - transform.position).normalized;
        tankMovementController.MoveForward(Vector3.Dot(transform.position.normalized,Direction));
		tankMovementController.Turn(Vector3.Cross(transform.position.normalized,Direction).x*10);

        //Debug.DrawLine(NavMeshAgent.nextPosition, NavMeshAgent.nextPosition.normalized * 1, Color.red);
		Debug.DrawLine(transform.position, Direction, Color.blue);

        print(Vector3.Cross(transform.position.normalized,Direction).x);

    }
}
