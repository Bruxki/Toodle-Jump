using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _sphere;

    private void Start()
    {
    }

    private void Update()
    {
        Vector3 vector = _sphere.position - base.transform.position;
        Debug.DrawRay(base.transform.position, vector, Color.green);
        Quaternion b = Quaternion.LookRotation(vector);
        base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * 2f);
    }
}
