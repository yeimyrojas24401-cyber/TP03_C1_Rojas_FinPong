using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class MainMenu : MonoBehaviour
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

    [Header("Sliders")]

    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;

    [Header("Players")]

    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;

    [Header("TextPlayers")]
    [SerializeField] private TMP_Text textSpeedPlayer1;
    [SerializeField] private TMP_Text textSpeedPlayer2;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
       // Buttons
        btnPlay.onClick.AddListener(OnPlayClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);

        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }


    private void Start()
    {
        //Panels
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }
    private void OnDestroy()
    {
        btnPlay.onClick.RemoveListener(OnPlayClicked);
        btnSettings.onClick.RemoveListener(OnSettingsClicked);
        btnCredits.onClick.RemoveListener(OnCreditsClicked);
        btnExit.onClick.RemoveListener(OnExitClicked);

        sliderPlayer1Speed.onValueChanged.RemoveListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.RemoveListener(OnPlayer2SpeedChanged);
    }
    private void OnPlayClicked()
    {
        mainMenuCanvas.SetActive(false);
    }

    private void OnSettingsClicked()
    {
        settingsPanel.SetActive(true);
        creditsPanel.SetActive(false);
        mainMenuCanvas.SetActive(false);

        sliderPlayer1Speed.value = player1.moveSpeed;
        sliderPlayer2Speed.value = player2.moveSpeed;
    }
    private void OnCreditsClicked()
    {
        creditsPanel.SetActive(true);
        settingsPanel.SetActive(false);
        mainMenuCanvas.SetActive(false);

    }

    private void OnPlayer1SpeedChanged (float value) // DENEMOS PONER float value porque asi le estamos diciendo que cuando sea llamada esta funcion va a recibir un float value
    {
        player1.moveSpeed = value;
        textSpeedPlayer1.text = value.ToString("F1"); // El F1 nos permite que se pongan valores sin decimal
    }
    private void OnPlayer2SpeedChanged(float value)
    {
        player2.moveSpeed = value;
        textSpeedPlayer2.text = value.ToString("F1"); // El F1 nos permite que se pongan valores sin decimal
    }
    private void OnExitClicked()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
