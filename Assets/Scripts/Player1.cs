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
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager.Instance es Null");
            return;
        }
        if (GameManager.Instance.player1Sprite == null)
        {
            Debug.LogError("Player1Sprite es Null");
            return;
        }
        if (spriteRenderer == null)
        {
            Debug.LogError("Player 1 no tiene spriteRenderer");
            return;
        }
        spriteRenderer.sprite = GameManager.Instance.player1Sprite;
    }
}
