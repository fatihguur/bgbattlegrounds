using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m4_powerchange : MonoBehaviour {

    public GameObject m4;
    public bool m4_birinci_upgrade = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(m4_birinci_upgrade == true)
        {
            m4.GetComponent<Weapon>().power = 20;
        }

        
		
	}
}
