using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startMenu;
    [SerializeField] GameObject levelCanvas;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] GameObject finishWindow;
    [SerializeField] DollarManager dollarManager;
    private void Start()
    {
        levelText.text = SceneManager.GetActiveScene().name;
    }
    public void Play()
    {
        startMenu.SetActive(false);
        levelCanvas.SetActive(true);
        FindObjectOfType<PlayerBehavior>().Play();
    }

    public TextMeshProUGUI moneyText;
    public void ShowFinishWindow()
    {
        finishWindow.SetActive(true);
        moneyText.text = dollarManager.numberOfDollars.ToString();
    }

    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            dollarManager.SaveToProgress();
            SceneManager.LoadScene(next);
        }

    }
}
