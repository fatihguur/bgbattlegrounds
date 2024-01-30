using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class railgun_buy : MonoBehaviour
{

    public GameObject text;
    public GameObject text2;
    public bool calisiyomu = false;
    public float sakal;
    public bool aldikmi = false;
    public bool onceden_aldikmi = false;

    public AudioClip cikcik;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        sakal = GameObject.FindGameObjectWithTag("OC").GetComponent<ekonomi>().para;
    }



    void OnTriggerEnter(Collider other)
    {
        if (aldikmi == false)
        {
            text.SetActive(true);
        }

        if (aldikmi == true)
        {
            text2.SetActive(true);
        }



    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && GameObject.FindGameObjectWithTag("OC").GetComponent<ekonomi>().para >= 150 && (onceden_aldikmi == false))
        {
            GameObject.FindGameObjectWithTag("OC").GetComponent<ekonomi>().para -= 150;
            GameObject.FindGameObjectWithTag("Weapons").GetComponent<WeaponSystem>().railgun_alma = true;
            text.SetActive(false);
            text2.SetActive(true);
            aldikmi = true;
            onceden_aldikmi = true;
            audioSource.PlayOneShot(cikcik, 6F);


        }

        if (onceden_aldikmi == true)
        {

        }


    }

    void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        text2.SetActive(false);
    }


}
