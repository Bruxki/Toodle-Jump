using System.Collections;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private int numbero;

    public int seconds;

    private void Start()
    {
        StartCoroutine(AddNumberRoutine());
    }

    private void Update()
    {
    }

    private IEnumerator AddNumberRoutine()
    {
        do
        {
            yield return new WaitForSeconds(1f);
            numbero++;
        }
        while (numbero < seconds);
        Debug.Log("finished");
        Object.Destroy(base.gameObject);
    }
}
