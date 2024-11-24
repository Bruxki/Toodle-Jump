using System.Collections;
using UnityEngine;

public class DestroyThisObject : MonoBehaviour
{
    public float seconds;

    private void Start()
    {
        StartCoroutine(AddNumberRoutine());
    }

    private IEnumerator AddNumberRoutine()
    {
        yield return new WaitForSeconds(seconds);
        Object.Destroy(base.gameObject);
    }
}
