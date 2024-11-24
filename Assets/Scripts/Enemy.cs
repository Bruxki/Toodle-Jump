using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;

    public GameObject player;

    private void Start()
    {
        if (-1 < PlayerPrefs.GetInt("HighScore"))
        {
            StartCoroutine(AddNumberRoutine());
        }
    }

    private IEnumerator AddNumberRoutine()
    {
        while (1500 < PlayerPrefs.GetInt("HighScore"))
        {
            yield return new WaitForSeconds(12f);
            Object.Instantiate(enemy, new Vector2(Random.Range(-11f, 11f), player.transform.position.y + (20f + Random.Range(5f, 10f))), Quaternion.identity);
        }
    }
}
