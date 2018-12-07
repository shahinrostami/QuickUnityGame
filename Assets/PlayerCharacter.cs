using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    public CharacterController body;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 pos = Vector3.zero;

        if (Input.GetKey("left"))
        {
            pos.x -= 10f;
        }
        if (Input.GetKey("right"))
        {
            pos.x += 10f;
        }

        body.SimpleMove(pos);
    }
}
