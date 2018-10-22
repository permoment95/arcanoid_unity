using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_brick : MonoBehaviour {



    public Button left_btn;
    public Button right_btn;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
            {
                //print("space key was pressed");
                transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
            }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //print("space key was pressed");
            transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
        }

        // print("AYR");
    }
}
