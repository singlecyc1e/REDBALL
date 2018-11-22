using UnityEngine;
using UnityEngine.SceneManagement;

public class Followinglight : MonoBehaviour
{

    public Vector3 offset;
    public Transform target;
    public float x = 0;
    public float y = 1.5f;
    public float z = 0;
    public float smoothspeed = 0.125f;


    private void LateUpdate()
    {
        offset = new Vector3(x, y, z);

        Vector3 FinalPostion = target.position + offset;
        Vector3 SoomthedPosition = Vector3.Lerp(transform.position, FinalPostion, smoothspeed);

        transform.position = SoomthedPosition;
      
    }
}
