using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public HealthBarController healthbar;
    // Start is called before the first frame update
    void Start()
    {
        health = 20;
    }

    public void Damage(float damage)
    {
        health -= damage;
        healthbar.SetHealth(health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
