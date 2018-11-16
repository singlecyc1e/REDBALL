using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour {
    public string nextscene;


    void OnTriggerEnter (Collider other)
    {

                SceneManager.LoadScene(nextscene);

    }



    private void OnTriggerExit(Collider other)
    {
 
    }
}
