using UnityEngine;
using UnityEngine.SceneManagement;

public class FC01 : MonoBehaviour
{

    public Vector3 offset;
    public float movingspeed = 0.3f;
    public Transform target;
    public float x = 0;
    public float y = 3;
    public float z = 0;
    public float dislimit = 10;

    private void Update()
    {
        if (y < dislimit)
        {
            y = y + movingspeed;

        }

        offset = new Vector3(x, y, z);
    }


    private void LateUpdate()
    {
        transform.position = target.position + offset;
        
    }
}
