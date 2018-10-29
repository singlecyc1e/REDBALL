using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

void OnTriggerEnter (Collider other)
{
    Debug.Log("switch on");
}
    void OnTriggerStay(Collider other)
    {
        Debug.Log("stay in");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");    
    }
}
