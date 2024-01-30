using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currency : MonoBehaviour {

    public Text myText;
    public Text myText2;
    public int para_miktari;
    public GameObject para_referansi;
    public float sakal;
    public float skor;

    

	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {
        sakal = GameObject.FindGameObjectWithTag("Player").GetComponent<ekonomi>().para;
        skor = GameObject.FindGameObjectWithTag("robotumben").GetComponent<Health>().Score;
        myText.text = "Currency : " + sakal.ToString();
        myText2.text = "Score : " + skor.ToString();

    }
}
