using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject deadEnemy;

    public GameObject ExplosionEffect;

    public AudioSource Sound1;

    private void Start()
    {
        Sound1.GetComponent<AudioSource>();
    }

    private void Soundplay()
    {
        Sound1.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Player") && collision.relativeVelocity.y <= 0f)
        {
            Soundplay();
            Rigidbody2D component = collision.collider.GetComponent<Rigidbody2D>();
            if (component != null)
            {
                Vector3 vector = component.linearVelocity;
                vector.y = 50f;
                component.linearVelocity = vector;
            }
            Object.Instantiate(deadEnemy, base.transform.position, Quaternion.identity);
            Object.Destroy(base.gameObject);
        }
    }
}