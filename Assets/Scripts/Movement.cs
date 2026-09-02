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
    [SerializeField] private float moveSpeed = 1f;

    [Header("Rotation Settings")]
    [SerializeField] private float rotationAngle = 10f;
    [SerializeField] private KeyCode rotationRight = KeyCode.E;
    [SerializeField] private KeyCode rotationLeft = KeyCode.Q;

    [Header("Color Settings")]
    [SerializeField] private KeyCode colorChange = KeyCode.R;
    private SpriteRenderer spriteRenderer; // esta es variable que queremos que guarde una referencia de un componente de un sprite

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // aqui desde que despierta mando a llamar a los componentes que existen dentro de mi sprite
    }

    // Update is called once per frame
    private void Update()
    {
        //Movement
        if (Input.GetKey(moveUp))
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(moveRight))
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(moveDown))
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(moveLeft))
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0);
        }
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
}
