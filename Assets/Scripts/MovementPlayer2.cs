using UnityEngine;

public class MovementPlayer2 : MonoBehaviour
{
    // The purpose of this script is to handle the movement of the player character in the game. It will allow the player to move left, right, up, and down. 

    [Header("Movement Settings")]
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveRight = KeyCode.D;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    [SerializeField] private KeyCode moveLeft = KeyCode.A;

    [SerializeField] private bool isContinuous = true;

    [Header("Speed Settings")]
    public float moveSpeedPlayer2 = 1f;
    private Rigidbody2D rb;

    void Awake()
    {
        // aqui desde que despierta mando a llamar a los componentes que existen dentro de mi sprite
        rb = GetComponent<Rigidbody2D>();
        moveSpeedPlayer2 = GameManager.Instance.player2Speed; //carga la velocidad instanciada desde el menu y la pone en el moveSpeed en esta nueva escena
    }
    private void FixedUpdate() // fisicas
    {
        if (isContinuous)
        {
            // Movimiento continuo con fisicas
            if (Input.GetKey(moveUp))
            {
                rb.AddForce(new Vector3(0, moveSpeedPlayer2 * Time.fixedDeltaTime));
            }
            if (Input.GetKey(moveRight))
            {
                rb.AddForce(new Vector3(moveSpeedPlayer2 * Time.fixedDeltaTime, 0));
            }
            if (Input.GetKey(moveDown))
            {
                rb.AddForce(new Vector3(0, -moveSpeedPlayer2 * Time.fixedDeltaTime));
            }
            if (Input.GetKey(moveLeft))
            {
                rb.AddForce(new Vector3(-moveSpeedPlayer2 * Time.fixedDeltaTime, 0));
            }
        }
        else
        {
            // Movimiento no continuo 
            if (Input.GetKey(moveUp))
            {
                rb.position += new Vector2(0, moveSpeedPlayer2 * Time.fixedDeltaTime);
            }
            if (Input.GetKey(moveRight))
            {
                rb.position += new Vector2(moveSpeedPlayer2 * Time.fixedDeltaTime, 0);
            }
            if (Input.GetKey(moveDown))
            {
                rb.position += new Vector2(0, -moveSpeedPlayer2 * Time.fixedDeltaTime);
            }
            if (Input.GetKey(moveLeft))
            {
                rb.position += new Vector2(-moveSpeedPlayer2 * Time.fixedDeltaTime, 0);
            }
        }

    }
}