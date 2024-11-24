using UnityEngine;

public class DownItGoes : MonoBehaviour
{
    public float speedo = 1f;

    private void Update()
    {
        base.transform.Translate(new Vector3(0f, speedo * -1f, 0f) * Time.deltaTime);
    }
}
