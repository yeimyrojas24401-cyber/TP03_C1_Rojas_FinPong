using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MayaMainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    //[Header("Pannels")]
    //[SerializeField] private GameObject panelSettings;
    //[SerializeField] private GameObject creditsSettings;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
    }


    private void OnDestroy()
    {
        btnPlay.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnPlayClicked()
    {
        throw new NotImplementedException();
    }
    private void OnSettingsClicked()
    {
        throw new NotImplementedException();
    }
    private void OnCreditsClicked()
    {
        throw new NotImplementedException();
    }
    private void OnExitClicked()
    {
        throw new NotImplementedException();
    }

}
