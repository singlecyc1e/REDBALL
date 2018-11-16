using UnityEngine;

public class Followingcamera : MonoBehaviour {

    public Vector3 offset;
    public float movingspeed = 1.0f;
    public Transform target;
    public float x = 0;
    public float y = 0.1f;
    public float z = -0.1f;
    public float dislimit = 5;

    private void Update()
    {
        if (y < dislimit) {
            y = y + 0.025f;
            z = z - 0.025f;
        }

        offset = new Vector3(x,y,z);
    }

    private void LateUpdate()
    {
        transform.position = target.position + offset;        
    }
}
