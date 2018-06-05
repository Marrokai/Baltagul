﻿using UnityEngine;
[RequireComponent(typeof(PlayerMotor))]
public class PlayerMovement : MonoBehaviour {
    public LayerMask movementMask;

    Camera cam;
    PlayerMotor motor;
    void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit,100, movementMask))
            {
                Debug.Log("We hit " + hit.collider.name + " " + hit.point);
                //Move our player to what we hit
                motor.MoveToPoint(hit.point);
                //Stop focusing any objects

            }
        }
	}
}
