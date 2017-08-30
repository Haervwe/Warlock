using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {
    public int health = 1;

	// Use this for initialization
	void OnTriggerEnter2D()
    {
        health -= 1;
    }
    void Die()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    
}
