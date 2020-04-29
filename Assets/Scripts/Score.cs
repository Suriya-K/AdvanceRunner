using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highscoreText;
    public float time = 0;
    public int score = 0;
    private void Start()
    {
        highscoreText.text = "BEST : " + PlayerPrefs.GetInt("Highscore").ToString();

    }
    // Update is called once per frame
    void Update()
    {
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
                        PlayerPrefs.SetInt("Highscore", score);
                        highscoreText.text = "BEST : " + PlayerPrefs.GetInt("Highscore").ToString();
                    }
                }
                time = 0;
            }
            scoreText.text = score.ToString();
        }
    }
}
