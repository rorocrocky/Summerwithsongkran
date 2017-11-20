using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingObject : MonoBehaviour {


    public GameObject projectile;
    public AudioClip shootSound;


    public float throwSpeed = 40f;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;


    void Awake()
    {

        source = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ball = Instantiate(projectile);
            ball.transform.position = transform.position;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            rb.velocity = camera.transform.rotation * Vector3.forward * throwSpeed;
        }

    }
}
