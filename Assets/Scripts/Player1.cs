using UnityEngine;

public class player1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent <SpriteRenderer>();
        Debug.Log("SpriteRender: " + spriteRenderer);
        Debug.Log("GameManager Instance: " + GameManager.Instance);
    }
    private void Start()
    {
        spriteRenderer.sprite = GameManager.Instance.player1Sprite;
    }
}
