using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public bool Player1 = true;
    public float speed = 10;

    [Header("Shooting")]
    public GameObject bulletPrefab;
    public float fireRate = 7;
    public Transform firePoint;
    [Header("Sound")]
    public AudioSource audioSource;

    private void Start()
    {
        InvokeRepeating(nameof(Shoot), fireRate, fireRate);
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
        audioSource.Play();
    }

    void Update()
    {
        var direction = new Vector3();
        if (Player1)
        {
            direction.x = Input.GetAxis("Horizontal");
            direction.z = Input.GetAxis("Vertical");
        }
        else
        {
            direction.x = Input.GetAxis("Horizontal2");
            direction.z = Input.GetAxis("Vertical2");
        }
        transform.position += direction * speed * Time.deltaTime;
        if (direction != Vector3.zero) transform.forward = direction;
    }
}
