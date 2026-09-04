using UnityEngine;

public class ColorC : MonoBehaviour
{
    [Header("Color Settings")]
    [SerializeField] private KeyCode colorChange = KeyCode.R;
    private SpriteRenderer spriteRenderer; // esta es variable que queremos que guarde una referencia de un componente de un sprite

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(colorChange))
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
