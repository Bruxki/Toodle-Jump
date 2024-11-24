using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Platform;

    private int _randomX;

    private void Start()
    {
        StartCoroutine(AddNumberRoutine());
    }

    private IEnumerator AddNumberRoutine()
    {
        while (true)
        {
            _randomX = Random.Range(-17, 17);
            Object.Instantiate(Platform, new Vector3(_randomX, 75f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
