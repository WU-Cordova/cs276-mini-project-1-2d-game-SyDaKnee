using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float elapsedTime = 0f;
    private float score = 0f;
    private Button restartButton;

    public float scoreMultiplier = 10f;
    public float thrustForce = 1f;
    public float maxSpeed = 5f;
    public GameObject boosterFlame;
    public GameObject explosionEffect;
    public GameObject borderParent;

    public InputAction moveForward;
    public InputAction lookPosition;

    Rigidbody2D rb;

    public UIDocument uiDocument;
    private Label scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void Start()
    {
        moveForward.Enable();
        lookPosition.Enable();

        rb = GetComponent<Rigidbody2D>();
        scoreText = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
        restartButton = uiDocument.rootVisualElement.Q<Button>("RestartButton");
        restartButton.clicked += ReloadScene;
        restartButton.style.display = DisplayStyle.None;
    }

    // Update is called once per frame.
    void Update()
    {
        UpdateScore();
        MovePlayer();
    }

    void UpdateScore()
    {
        elapsedTime += Time.deltaTime;
        score = Mathf.FloorToInt(elapsedTime * scoreMultiplier);
        scoreText.text = "Score: " + score;
    }

    void MovePlayer()
{
    if (moveForward.IsPressed())
    {
        boosterFlame.SetActive(true);

        // Calculates the touch position.
        Vector3 touchPos = Camera.main.ScreenToWorldPoint(lookPosition.ReadValue<Vector2>());
        Vector2 direction = (touchPos - transform.position).normalized;

        // Rotate rocket to face direction.
        transform.up = direction;

        // Apply thrust continuously while pressed.
        rb.AddForce(direction * thrustForce);

        // Cap max speed.
        if (rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
    }
    else
    {
        boosterFlame.SetActive(false);
    }
}


    void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);

        restartButton.style.display = DisplayStyle.Flex;
        borderParent.SetActive(false);

        Destroy(gameObject);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
