using UnityEngine;

public class Player1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent <SpriteRenderer>(); // Apenas despiertes traeme a mi sprite renderer
    }
    private void Start()
    {
        UpdateSprite(); //esto nos permitira que el GameManagerInstance se pueda seguir updateando
    }
    public void UpdateSprite ()
    {
        spriteRenderer.sprite = GameManager.Instance.player1Sprite;
    }
}
