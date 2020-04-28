using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public float maxLifetime = 1.75f;
    public float damage = 1f;
    public float speed = 25f;
    bool hasHit = false;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, maxLifetime);
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        hasHit = false;
    }

    private void OnTriggerEnter(Collider target)
    {
        if (hasHit)
        {
            return;
        }
        hasHit = true;

        CharacterHealth targetHealth = target.GetComponent<CharacterHealth>();

        if (!targetHealth)
        {
            return;
        }

        targetHealth.Damage(damage);
    }
}
