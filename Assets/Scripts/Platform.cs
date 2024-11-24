using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject brokenplatform;

    public GameObject ExplosionEffect;

    public GameObject bouncy;

    public GameObject platform;

    public AudioSource sound;

    public AudioSource sound1;

    public float jumpForce1 = 40f;

    private void Start()
    {
        sound.GetComponent<AudioSource>();
        sound1.GetComponent<AudioSource>();
    }

    private void Sound1()
    {
        sound.Play();
    }

    private void Sound2()
    {
        sound1.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((!collision.gameObject.name.StartsWith("Player") && !collision.gameObject.name.StartsWith("Enemy")) || !(collision.relativeVelocity.y <= 0f))
        {
            return;
        }
        Rigidbody2D component = collision.collider.GetComponent<Rigidbody2D>();
        if (!(component != null))
        {
            return;
        }
        Vector3 vector = component.linearVelocity;
        vector.y = jumpForce1;
        component.linearVelocity = vector;
        if (jumpForce1 > 100f && collision.gameObject.name.StartsWith("Player"))
        {
            Object.Instantiate(ExplosionEffect, base.transform.position, Quaternion.identity);
            Rigidbody[] componentsInChildren = Object.Instantiate(brokenplatform, base.transform.position, Quaternion.identity).GetComponentsInChildren<Rigidbody>();
            if (componentsInChildren.Length != 0)
            {
                Rigidbody[] array = componentsInChildren;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].AddExplosionForce(500f, base.transform.position, 1f);
                }
            }
            Sound2();
        }
        Sound1();
    }
}
