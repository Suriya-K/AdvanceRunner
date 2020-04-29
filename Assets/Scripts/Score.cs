using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highscoreText;
    public static string bestscoreText = "";
    public float time = 0;
    public int score = 0;
    // Update is called once per frame
    private void Start()
    {
        PlayerPrefs.SetInt("Highscore", score);
    }
    void Update()
    {
        highscoreText.text = "BEST : " + PlayerPrefs.GetInt("Highscore").ToString();
        if (GameManager.isStart)
        {
            time++;
            if (time > Time.deltaTime * 2)
            {
                if (!PlayerCollision.isPlayerHit)
                {
                    score += 1;
                    if (score > PlayerPrefs.GetInt("Highscore"))
                    {
                        highscoreText.text = "BEST : " + PlayerPrefs.GetInt("Highscore").ToString();
                        bestscoreText = "YOU BEST : " + PlayerPrefs.GetInt("Highscore").ToString();
                    }
                }
                time = 0;
            }
            scoreText.text = score.ToString();
        }
    }
    public static string getbestScore()
    {
        return PlayerPrefs.GetInt("Highscore").ToString();
    }
}
