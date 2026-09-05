using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; /// A ESTO SE LE LLAMA PERSISTENT DATA VARIABLES PERSISTENTE ENTRE ESCENAS BUSCAR: SINGLETONE

    public float player1Speed = 1000f;
    public float player2Speed = 1000f;

    public Sprite player1Sprite;
    public Sprite player2Sprite;

    public Color player1Color = Color.white;
    public Color player2Color = Color.white;

    private void Awake() // CARACTERISTICA DE SINGLE TONE ES ESTO BUSCAR: SINGLETONE BUSCAR MAS INFO
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
