using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthScript : MonoBehaviour
{
    private int health = 100;
    public event Action<int> HealthDepleted;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetHealth(int aNumber) {
        health = aNumber;
        if (health <= 0) {
            health = 0;

        }
    }

    public int GetHealth() {
        return health;
    }
}
