using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
       // Buttons
        btnPlay.onClick.AddListener(OnPlayClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
    }

    private void Start()
    {
        //Panels
        mainMenuCanvas.SetActive(true);
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }
    private void OnDestroy()
    {
        btnPlay.onClick.RemoveListener(OnPlayClicked);
        btnSettings.onClick.RemoveListener(OnSettingsClicked);
        btnCredits.onClick.RemoveListener(OnCreditsClicked);
        btnExit.onClick.RemoveListener(OnExitClicked);
    }
    // Update is called once per frame
    void Update()
    {

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
    }
    private void OnCreditsClicked()
    {
        creditsPanel.SetActive(true);
        settingsPanel.SetActive(false);
        mainMenuCanvas.SetActive(false);

    }
    private void OnExitClicked()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
