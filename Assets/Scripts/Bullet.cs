using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public float lifetime = 3;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime; 
    }
}
