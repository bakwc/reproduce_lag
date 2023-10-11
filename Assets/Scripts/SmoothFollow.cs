using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public GameObject OBJECT_TO_TRACK;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (OBJECT_TO_TRACK == null)
        {
            return;
        }
        var targetPosition = OBJECT_TO_TRACK.transform.position + new Vector3(0, 1, -10);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
