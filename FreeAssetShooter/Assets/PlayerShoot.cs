using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject lazer;
    public Transform firePosition;
    public float speedMulitplier = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject lazerInstance = Instantiate(lazer, firePosition.position, firePosition.rotation);
    }
}
