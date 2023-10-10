using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Object;

public class GameManager : NetworkBehaviour
{
    public GameObject OBJECT_TO_SPAWN;
    void Start()
    {
        if (base.IsServer) 
        {
            SpawnObject();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        var obj = Instantiate(OBJECT_TO_SPAWN);
        base.Spawn(obj);
    }
}
