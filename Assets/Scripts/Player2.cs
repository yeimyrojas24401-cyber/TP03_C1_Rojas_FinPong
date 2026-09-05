using UnityEngine;

public class Player2 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        UpdateSprite(); //esto nos permitira que el GameManagerInstance se pueda seguir updateando
    }
    public void UpdateSprite()
    {
        spriteRenderer.sprite = GameManager.Instance.player2Sprite;
    }

}
