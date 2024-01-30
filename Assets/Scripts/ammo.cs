using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour {

    public int health = 40;

	

    private void OnCollisionEnter(Collision collision)
    {
        health = health - 20;

        if (health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
