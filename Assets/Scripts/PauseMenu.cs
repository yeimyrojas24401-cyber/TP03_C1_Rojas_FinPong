using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;


    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject pausePanel;

    [Header("Slider")]
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;

    [Header("Players")]
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;

    [Header("SpeedPlayersTMP")]
    [SerializeField] private TMP_Text textSpeedPlayer1;
    [SerializeField] private TMP_Text textSpeedPlayer2;

    private bool isPause = false;

    private void Awake() // solo para add listener y get components porque esta es la inicializacion (todas las referencias)
    {
        btnContinue.onClick.AddListener(OnContinueClicked); // "When click in btnPlay ejecuta OnContinueClicked
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);

        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged); //cuando el valor del slider cambie ejecuta OnPlayer1SpeedChanged
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }

    private void Start()
    {
        creditsPanel.SetActive(false); // alt + flecha hacia abajo y arriba para mover lineas 
        settingsPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnContinueClicked();
        }
    }

    private void OnDestroy() // for each add Listener we need to put one remove listener es como decir cuando este objeto vaya a destruirse, ya no ejecutes las cosas que estaban conectadas conmigo
    {
        btnContinue.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();

        sliderPlayer1Speed.onValueChanged.RemoveListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.RemoveListener(OnPlayer2SpeedChanged);
    }

    private void OnContinueClicked()
    {
        isPause = !isPause; //!igual a lo opuesto
        pausePanel.SetActive(isPause);
        if (isPause)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    private void OnSettingsClicked()
    {
        sliderPlayer1Speed.value = player1.moveSpeed;
        sliderPlayer2Speed.value = player2.moveSpeed;
        settingsPanel.SetActive(true);
    }

    private void OnCreditsClicked()
    {
        creditsPanel.SetActive(true);
    }

    private void OnExitClicked()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    private void OnPlayer2SpeedChanged(float value)
    {
        player2.moveSpeed = value;
        textSpeedPlayer2.text = value.ToString("F1");
    }

    private void OnPlayer1SpeedChanged(float value)
    {
        player1.moveSpeed = value;
        textSpeedPlayer1.text = value.ToString("F1");
    }
}