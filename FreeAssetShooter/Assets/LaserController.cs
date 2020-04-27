using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public float maxLifetime = 3f;
    public float damage = 1f;
    public float speed = 25f;
    Vector3 direction;
    Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Made a lazer");
        Destroy(gameObject, maxLifetime);
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    private void OnTriggerEnter(Collider target)
    {
        Debug.Log("Lazer collision");
        CharacterHealth targetHealth = target.GetComponent<CharacterHealth>();

        if (!targetHealth)
        {
            Debug.Log("No health!");
            return;
        }

        targetHealth.Damage(damage);
    }
}
