using UnityEngine;

public class NewPlatform : MonoBehaviour
{
    public GameObject platform;

    public int numberOfPlatforms = 100;

    public float levelWidth = 12f;

    public float minY = 5f;

    public float maxY = 15f;

    private void Start()
    {
        Vector3 position = default(Vector3);
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            position.y += Random.Range(minY, maxY);
            position.x = Random.Range(0f - levelWidth, levelWidth);
            Object.Instantiate(platform, position, Quaternion.identity);
        }
    }
}
