using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [Range(1, 2)][SerializeField] private int playerIndex = 1;
    private void Awake()
    {
        spriteRenderer = GetComponent <SpriteRenderer>(); // Apenas despiertes traeme a mi sprite renderer
    }

    private void Start()
    {
        UpdateSprite(); //esto nos permitira que el GameManagerInstance se pueda seguir updateando
        UpdateColor();
    }

    public void UpdateSprite ()
    {
        Destroy(spriteRenderer.GetComponent<BoxCollider2D>()); //aqui destruye el collider que ya estaba
        // este switch sirve para que dependiendo del jugar, asignamos un su sprite
        switch (playerIndex)
        {
            case 1:
                spriteRenderer.sprite = GameManager.Instance.player1Sprite;
                break;
            case 2:
                spriteRenderer.sprite = GameManager.Instance.player2Sprite;
                break;
            default:
                spriteRenderer.sprite = GameManager.Instance.player1Sprite;
                break;
        }
        spriteRenderer.AddComponent<BoxCollider2D>(); // aqui agrega un nuevo box collider, que al agreagrse por automatico se adapta al nuevo sprite
    }

    public void UpdateColor ()
    {
        switch (playerIndex)
        {
            case 1:
                spriteRenderer.color = GameManager.Instance.player1Color;
                break;
            case 2:
                spriteRenderer.color = GameManager.Instance.player2Color;
                break;
            default:
                spriteRenderer.color = GameManager.Instance.player1Color;
                break;
        }
    }
}
