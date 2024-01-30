using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour {

    public float CurrentHealth;
    public float MaxHealth;

    public Slider healthbar;

    public AudioClip[] cikcikArray;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        MaxHealth = 100f;

        CurrentHealth = MaxHealth;

        healthbar.value = CalculateHealth();

        audioSource = GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.X))
            DealDamage(6);

        audioSource.clip = cikcikArray[Random.Range(0, cikcikArray.Length)];
    }
		
    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        healthbar.value = CalculateHealth();

        if (CurrentHealth <= 0)
            Die();
    }


    float CalculateHealth()
    {
        return CurrentHealth / MaxHealth;
    }


    void Die()
    {
        CurrentHealth = 0;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "robot_degmesi")
        {
            DealDamage(20);
            audioSource.PlayOneShot(audioSource.clip);

        }

    }

}
