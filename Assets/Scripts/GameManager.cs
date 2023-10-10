using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Object;

public class GameManager : NetworkBehaviour
{
    public GameObject OBJECT_TO_SPAWN;
    bool spawned = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (base.IsServer && !spawned) 
        {
            SpawnObject();
            spawned = true;
        }
    }

    void SpawnObject()
    {
        var obj = Instantiate(OBJECT_TO_SPAWN);
        base.Spawn(obj);
    }
}
