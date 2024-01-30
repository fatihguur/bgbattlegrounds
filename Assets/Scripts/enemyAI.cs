using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {

    public float speed;

    private Transform target;

	// Use this for initialization
	void Start () {

        target = GameObject.FindGameObjectWithTag("Team2").GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Vector3.Distance(transform.position, target.position) >2)
        { 
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
