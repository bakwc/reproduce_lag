using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Object;

public class TestObject : MonoBehaviour
{
    public Vector3 FORCE_DIRECTION;
    public float THRUST;
    void Start()
    {
        Camera.main.GetComponent<SmoothFollow>().OBJECT_TO_TRACK = gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddForce(FORCE_DIRECTION * THRUST * Time.fixedDeltaTime);
    }

    void Update() {
        print("pos: " + Time.time + " " + transform.position.x);
    }
}
