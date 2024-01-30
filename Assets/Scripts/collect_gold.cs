using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_gold : MonoBehaviour {

    public float money = 0;

    public AudioClip cikcik;
    AudioSource audioSource;


    // Use this for initialization
    void Start () {

        audioSource = GameObject.FindGameObjectWithTag("Team2").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Team2")
        {
            Destroy(this.gameObject);
            GameObject.FindGameObjectWithTag("OC").GetComponent<ekonomi>().para += 20;
            audioSource.PlayOneShot(cikcik, 1F);



        }
    }
}
