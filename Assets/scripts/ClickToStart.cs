using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToStart : MonoBehaviour
{
    public bool sw = false;

    private void OnMouseDown()
    {
        sw = true;
  
    }
}