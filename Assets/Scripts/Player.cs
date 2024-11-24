using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public int health;

    public Text scoreText;

    public float TopScore;

    private bool isStarted;

    public Text startText;

    public Text TopText;

    public int number;

    public GameObject DeadPlayer;

    [SerializeField]
    public float Speed = 10f;

    public float jumpForce = 10f;

    [SerializeField]
    private float _HorizontalInput;

    public Transition other;

    public GameObject itself;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isStarted)
        {
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isStarted)
        {
            isStarted = true;
            startText.gameObject.SetActive(value: false);
        }
        if (isStarted)
        {
            if (rb2d.linearVelocity.y > 0f && base.transform.position.y > TopScore)
            {
                TopScore = base.transform.position.y;
            }
            scoreText.text = "Score: " + Mathf.Round(TopScore);
            _HorizontalInput = Input.GetAxis("Horizontal");
            base.transform.Translate(new Vector2(_HorizontalInput, 0f) * Speed * Time.deltaTime);
        }
        number = Mathf.RoundToInt(TopScore);
        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
        }
        if (TopScore > 16000f)
        {
            other.Deatho();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Destroyer"))
        {
            other.Deatho();
        }
        if (collision.gameObject.name.StartsWith("Death"))
        {
            other.Deatho();
        }
    }
}
