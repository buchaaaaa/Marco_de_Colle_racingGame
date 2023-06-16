using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointmanager : MonoBehaviour
{

    private checkpoint[] chekpoints;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindObjectsOfType<checkpoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
