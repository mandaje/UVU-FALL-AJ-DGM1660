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
    public TextMeshProUGUI titleTxt;

    public Button restartButton;
    public Button startButton;
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
        gameOverTxt.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        titleTxt.gameObject.SetActive(true);
        startButton.gameObject.SetActive(true);
        Debug.Log(startButton.gameObject.name + "was clicked");
        
   }
   public void OnMouseDown()
   {
        if(gameManager.isGameActive)
       {
           titleTxt.gameObject.SetActive(false);
            startButton.gameObject.SetActive(false);
       }
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
}
