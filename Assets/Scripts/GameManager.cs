using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float player1Speed = 1000f;
    public float player2Speed = 1000f;

    public Sprite player1Sprite;
    public Sprite player2Sprite;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
