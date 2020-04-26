using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public float maxLifetime = 3f;
    public float damage = 1f;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, maxLifetime);
    }

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * speed;
    }

    private void OnTriggerEnter(Collider target)
    {
        CharacterHealth targetHealth = target.GetComponent<CharacterHealth>();

        if (!targetHealth)
        {
            return;
        }

        targetHealth.Damage(damage);
    }
}
