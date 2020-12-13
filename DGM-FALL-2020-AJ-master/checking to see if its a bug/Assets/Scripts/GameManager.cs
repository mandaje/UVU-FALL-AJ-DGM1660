using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI gameOverTxt;
    public TextMeshProUGUI endGameTxt;
    public TextMeshProUGUI prizeTxt;


    public Button restartButton;
    public Button startButton;
    public GameObject titleScreen;

     public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
   {
       isGameActive = true;
       titleScreen.gameObject.SetActive(false);
        gameOverTxt.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        prizeTxt.gameObject.SetActive(false);
        
   }


     public void GameOver()
    {
       gameOverTxt.gameObject.SetActive(true);
       restartButton.gameObject.SetActive(true); 
       isGameActive = false; 
        Debug.Log(restartButton.gameObject.name + "was clicked");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        endGameTxt.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true); 
    }
     public void HasPrize()
    {
        prizeTxt.gameObject.SetActive(true);
    }
}
