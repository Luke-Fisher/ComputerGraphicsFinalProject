using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }
    
    public void Damage(float damage)
    {
        Debug.Log("Took damage: " + damage.ToString());
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
