using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetButton("Fire1"))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X"), 0, Space.World);
        }



        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(horizontal * 0.3f, Input.GetAxisRaw("Mouse ScrollWheel") * 5, vertical * 0.3f);

    }
}
