using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float rotationAngle = 10f;
    [SerializeField] private KeyCode rotationRight = KeyCode.E;
    [SerializeField] private KeyCode rotationLeft = KeyCode.Q;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Rotation 
        if (Input.GetKeyDown(rotationRight))
        {
            rb.AddTorque(rotationAngle, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(rotationLeft))
        {
            rb.AddTorque(-rotationAngle, ForceMode2D.Impulse);
        }
    }
}
