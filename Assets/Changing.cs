using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changing : MonoBehaviour {
    float cx, cy, cz;
    Vector3 startpoint;
    Vector3 endingsize;
    // Use this for initialization
    void Start () {
        cx = 1;
        cy = 0.2f;
        cz = 1;
        startpoint = transform.position;
      

    }
	
	// Update is called once per frame
	void Update () {
        cx += 0.02f;
        endingsize = transform.localScale;
        if (endingsize != new Vector3(5, 0.2f, 1))
        {
        transform.localScale = new Vector3(cx, cy, cz);	
        transform.localPosition = startpoint + new Vector3(0.5f * cx, 0, 0);
        }
    }
}
