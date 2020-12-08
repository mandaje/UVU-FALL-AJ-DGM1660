using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverTxt;

    public Button restartButton;

    public bool isGameActive;
    public GameObject titleScreen;

    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }
    public void GameOver()
    {
       gameOverTxt.gameObject.SetActive(true);
       restartButton.gameObject.SetActive(true); 
       isGameActive = false; 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
   
    public void UpdateScore(int scoreToAdd)
   {
       score += scoreToAdd;
       scoreText.text = "Score: " + score;
   }

   public void StartGame(int difficulty)
   {
       isGameActive = true;
        score = 0;
        spawnRate /= difficulty;
        StartCoroutine(SpawnTarget());
        gameOverTxt.gameObject.SetActive(false);
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
   }
}
