using UnityEngine;

public class TheDestroyer : MonoBehaviour
{
    public GameObject player;

    public GameObject platform;

    public GameObject bouncy;

    public Transition other;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 15) == 1)
            {
                Object.Destroy(collision.gameObject);
                Object.Instantiate(bouncy, new Vector2(Random.Range(-12f, 12f), player.transform.position.y + (20f + Random.Range(0f, 0f))), Quaternion.identity);
            }
            else
            {
                Object.Destroy(collision.gameObject);
                Object.Instantiate(platform, new Vector2(Random.Range(-12f, 12f), player.transform.position.y + (20f + Random.Range(0f, 0f))), Quaternion.identity);
            }
        }
        else if (collision.gameObject.name.StartsWith("Bouncy"))
        {
            if (Random.Range(1, 15) == 1)
            {
                Object.Destroy(collision.gameObject);
                Object.Instantiate(bouncy, new Vector2(Random.Range(-12f, 12f), player.transform.position.y + (20f + Random.Range(0f, 0f))), Quaternion.identity);
            }
            else
            {
                Object.Destroy(collision.gameObject);
                Object.Instantiate(platform, new Vector2(Random.Range(-12f, 12f), player.transform.position.y + (20f + Random.Range(0f, 0f))), Quaternion.identity);
            }
        }
        if (collision.gameObject.name.StartsWith("Player"))
        {
            other.Deatho();
        }
    }
}
