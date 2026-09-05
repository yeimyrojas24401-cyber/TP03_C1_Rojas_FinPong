using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }
    private void Launch()
    {
        float xVelocity = Random.Range(0,2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0,2) == 0 ? 1 : -1;
        ballRb.linearVelocity = new Vector2(xVelocity, yVelocity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
