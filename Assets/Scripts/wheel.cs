using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    SpinWheel obj;
    public GameObject wheelTOspin;
    // Start is called before the first frame update
    void Start()
    {
        obj = new SpinWheel(8);
        obj.setMaxTime(10);
        obj.setMinTime(2);
        obj.setVelocity(10);
        obj.setWheel(wheelTOspin);
        
        StartCoroutine( obj.StartNewRun());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
