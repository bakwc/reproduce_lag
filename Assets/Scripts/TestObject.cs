using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Object;

public class TestObject : NetworkBehaviour
{
    public Vector3 FORCE_DIRECTION;
    public float THRUST;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (base.IsServer)
        {
            var rb = GetComponent<Rigidbody>();
            rb.AddForce(FORCE_DIRECTION * THRUST * Time.fixedDeltaTime);
        }
    }
}
