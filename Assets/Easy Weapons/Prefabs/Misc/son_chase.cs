﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class son_chase : MonoBehaviour {

    private NavMeshAgent myAgent;
    public Transform target;

	// Use this for initialization
	void Start () {

        myAgent = GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {

        myAgent.SetDestination(target.position);
		
	}
}
