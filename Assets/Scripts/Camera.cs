using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.3f;

    private Vector3 currentVelocity;

    private void LateUpdate()
    {
        if (target.position.y > base.transform.position.y)
        {
            Vector3 vector = new Vector3(base.transform.position.x, target.position.y, base.transform.position.z);
            base.transform.position = Vector3.SmoothDamp(base.transform.position, vector, ref currentVelocity, smoothSpeed * Time.deltaTime);
        }
    }
}
