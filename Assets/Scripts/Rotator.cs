using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float rotationAngle = 10f;
    [SerializeField] private KeyCode rotationRight = KeyCode.E;
    [SerializeField] private KeyCode rotationLeft = KeyCode.Q;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }
}
