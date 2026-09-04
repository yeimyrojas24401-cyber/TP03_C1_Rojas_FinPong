using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // The purpose of this script is to handle the movement of the player character in the game. It will allow the player to move left, right, up, and down. 

    [Header("Movement Settings")]
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveRight = KeyCode.D;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    [SerializeField] private KeyCode moveLeft = KeyCode.A;

    [Header("Speed Settings")]
    public float moveSpeed = 1f;

    [Header("Rotation Settings")]
    [SerializeField] private float rotationAngle = 10f;
    [SerializeField] private KeyCode rotationRight = KeyCode.E;
    [SerializeField] private KeyCode rotationLeft = KeyCode.Q;

    [Header("Color Settings")]
    [SerializeField] private KeyCode colorChange = KeyCode.R;
    private SpriteRenderer spriteRenderer; // esta es variable que queremos que guarde una referencia de un componente de un sprite


    private Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // aqui desde que despierta mando a llamar a los componentes que existen dentro de mi sprite
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Rotation 
        if (Input.GetKeyDown(rotationRight))
        {
            transform.Rotate(Vector3.forward * -rotationAngle);
        }

        if (Input.GetKeyDown(rotationLeft))
        {
            transform.Rotate(Vector3.forward * rotationAngle);
        }
        if (Input.GetKeyUp(colorChange))
        {
            spriteRenderer.color = new Color (Random.value, Random.value, Random.value);
        }
    }
    private void FixedUpdate() // fisicas
    {
        // Movimiento
        if (Input.GetKey (moveUp))
        {
            rb.AddForce(new Vector3(0, moveSpeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(moveRight))
        {
            rb.AddForce(new Vector3(moveSpeed * Time.fixedDeltaTime, 0));
        }
        if (Input.GetKey(moveDown))
        {
            rb.AddForce (new Vector3(0, -moveSpeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(moveLeft))
        {
            rb.AddForce (new Vector3(-moveSpeed * Time.fixedDeltaTime, 0));
        }
    }
}
