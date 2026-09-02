using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    [Header("Panels")]

    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject pausePanel;

    [Header("Sliders")]
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;

    [Header("Players")]
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;

    [Header("Players")]
    [SerializeField] private TMP_Text TextPlayer1;
    [SerializeField] private TMP_Text TextPlayer2;
   
    private bool isPause = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake ()
    {
        btnContinue.onClick.AddListener(OnContinueClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);

        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }


    private void Start()
    {
        creditsPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnContinueClicked();
        }
    }

    private void OnDestroy()
    {
        btnContinue.onClick.RemoveListener(OnContinueClicked);
        btnSettings.onClick.RemoveListener(OnSettingsClicked);
        btnCredits.onClick.RemoveListener(OnCreditsClicked);
        btnExit.onClick.RemoveListener(OnExitClicked);

        sliderPlayer1Speed.onValueChanged.RemoveListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.RemoveListener(OnPlayer2SpeedChanged);
    }
    private void OnContinueClicked()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isPause = !isPause;
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
    private void OnPlayer1SpeedChanged(float value)
    {
        player1.moveSpeed = value;
        TextPlayer1.text = value.ToString("F1");
    }
    private void OnPlayer2SpeedChanged(float value)
    {
        player2.moveSpeed = value;
        TextPlayer2.text = value.ToString("F1");
    }
}
