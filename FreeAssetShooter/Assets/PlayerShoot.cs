using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject lazer;
    public Transform firePosition;
    public float speedMulitplier = 5f;
    bool isShooting = false;
    public float nextShotTimer = .2f;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isShooting)
        {
            nextShotTimer -= Time.deltaTime;
            if (nextShotTimer < 0)
            {
                isShooting = false;
                nextShotTimer = .2f;
            }
        }

        if (Input.GetMouseButton(0) && !isShooting)
        {
            isShooting = true;
            Fire();
        }
    }

    void Fire()
    {
        GameObject lazerInstance = Instantiate(lazer, firePosition.position, firePosition.rotation);
        //lazerInstance.transform.position = 
    }
}
