using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Managing.Timing;
// using FishNet.Runtime.Managing.Timing;

public class NetworkConfigurator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var time_manager = GetComponent<TimeManager>();
        // time_manager.TickDelta = Time.fixedDeltaTime;
        // time_manager.OnTick += OnNetworkTick;
    }

    public void OnNetworkTick()
    {
        
    }
}
