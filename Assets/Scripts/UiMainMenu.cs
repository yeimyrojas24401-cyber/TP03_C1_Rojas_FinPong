using TMPro;
// si hay algo gris no lo necesito
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiMainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    [Header("Panels")]
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;

    [Header("Slider")]
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;

    //[Header("Players")]
    //[SerializeField] private Movement player1;
    //[SerializeField] private Movement player2;

    [Header("SpeedPlayersTMP")]
    [SerializeField] private TMP_Text textSpeedPlayer1;
    [SerializeField] private TMP_Text textSpeedPlayer2;

    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayClicked); // "When click in btnPlay ejecuta OnContinueClicked
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);

        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged); //cuando el valor del slider cambie ejecuta OnPlayer1SpeedChanged
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    private void OnDestroy() // for each add Listener we need to put one remove listener es como decir cuando este objeto vaya a destruirse, ya no ejecutes las cosas que estaban conectadas conmigo
    {
        btnPlay.onClick.RemoveListener(OnPlayClicked);
        btnSettings.onClick.RemoveListener(OnSettingsClicked);
        btnCredits.onClick.RemoveListener(OnCreditsClicked);
        btnExit.onClick.RemoveListener(OnExitClicked);

        sliderPlayer1Speed.onValueChanged.RemoveListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.RemoveListener(OnPlayer2SpeedChanged);
    }

    private void OnPlayClicked() // this is the function called OnContinueClicked which is going to run when the btnPlay click
    {
        mainMenuCanvas.SetActive(false); //  When Play is clicked, this GameObject becomes inactive.
        SceneManager.LoadScene("Gameplay03");
    }

    private void OnSettingsClicked()
    {
        //sliderPlayer1Speed.value = player1.moveSpeed;
        //sliderPlayer2Speed.value = player2.moveSpeed;
        mainMenuCanvas.SetActive(false);
        settingsPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    private void OnCreditsClicked()
    {
        creditsPanel.SetActive(true);
        mainMenuCanvas.SetActive(false);
        settingsPanel.SetActive(false);
    }

    private void OnPlayer1SpeedChanged(float value) // esta funcion va a recibir un numero decimal cuando sea llamada
    {
        //player1.moveSpeed = value;
        //// float percentage = value * 25f; //esto nos permite hacer una equivalencia para que la velocidad se ponga en %
        //textSpeedPlayer1.text = value.ToString("F1");
    }

    private void OnPlayer2SpeedChanged(float value)
    {
        //player2.moveSpeed = value;
        //textSpeedPlayer2.text = value.ToString("F1");
    }
    private void OnExitClicked()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}