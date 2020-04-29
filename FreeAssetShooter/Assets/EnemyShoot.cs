using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    float distanceToPlayer;
    public float sightRange = 5f;
    public float nextShotTimer = 1.5f;
    public Transform firePosition;
    public Transform player;
    public GameObject lazer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);
        Debug.Log(distanceToPlayer.ToString());
        if (distanceToPlayer < sightRange)
        {
            Debug.Log("ATTACKING");
            transform.LookAt(player);
            Attack();
        }
    }

    void Attack()
    {
        nextShotTimer -= Time.deltaTime;
        if (nextShotTimer <= 0)
        {
            Fire();
            nextShotTimer = 0.5f;
        }
    }

    void Fire()
    {
        GameObject lazerInstance = Instantiate(lazer, firePosition.position, firePosition.rotation);
    }
}
