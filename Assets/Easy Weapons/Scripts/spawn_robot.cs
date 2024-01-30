using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_robot : MonoBehaviour {

    public bool wave1 = false;
    public GameObject robot;

	// Use this for initialization
	void Start () {

       
        {
            Instantiate(robot, transform.position, transform.rotation);
        } 

    }
	
	// Update is called once per frame
	void Update () {

       
		
	}
}
