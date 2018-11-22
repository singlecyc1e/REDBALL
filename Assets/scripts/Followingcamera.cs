using UnityEngine;
using UnityEngine.SceneManagement;


public class Followingcamera : MonoBehaviour{

    public Vector3 offset;
    public float movingspeed = 1.0f;
    public Transform target;
    public float x = 0;
    public float y = 25;
    public float z = 0;
    public float dislimit = 5;
    public string levelstring;
    public ClickToStart obj;
    

    private void Update()
    {
        Debug.Log(obj.sw);
        if (y > dislimit && obj.sw == true)
        {
            y = y - movingspeed;
        
        }

        offset = new Vector3(x,y,z);
    }


    private void LateUpdate()
    {
        transform.position = target.position + offset;    
        if (y < dislimit)
        {
            SceneManager.LoadScene(levelstring);
        }
    }
}
