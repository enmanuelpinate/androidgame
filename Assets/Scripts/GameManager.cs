using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score;
    public Text scoreText;
    public Text bestScore;
    public Text scoreContinue;
    public GameObject gameStartUI;
    public GameObject continueUI;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart() {
        gameStartUI.SetActive(false);
        continueUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
        bestScore.gameObject.SetActive(true);
    }

    public void ContinueGame() {
        continueUI.SetActive(true);
        scoreText.gameObject.SetActive(false);
        bestScore.gameObject.SetActive(false);
    }

    public void Restart() {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp() {
        score++;
        scoreText.text = score.ToString();
        scoreContinue.text = score.ToString();
    }
}
