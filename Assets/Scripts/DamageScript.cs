using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    private int health;
    public HealthScript healthH;
    //public event Action<Health> HealthDepleted;
    void Start()
    {
        health = healthH.GetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        healthH.SetHealth(health);
    }

    public void TakeDamage() {
        health -= Random.Range(1, 5);
        
    }

}
