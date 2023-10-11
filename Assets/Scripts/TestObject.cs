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
        Camera.main.GetComponent<SmoothFollow>().OBJECT_TO_TRACK = gameObject;
        FishNet.InstanceFinder.TimeManager.OnTick += TickFixedUpdate;
    }

    // Update is called once per frame
    void TickFixedUpdate()
    {
        if (base.IsServer)
        {
            var rb = GetComponent<Rigidbody>();
            rb.AddForce(FORCE_DIRECTION * THRUST * Time.fixedDeltaTime);
        }
    }

    void Update() {
        print("pos: " + Time.time + " " + transform.position.x);
    }
}
