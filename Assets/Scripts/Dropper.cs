using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rb.useGravity = false;

    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
