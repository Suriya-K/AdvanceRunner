using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showBestscore : MonoBehaviour
{
    public Text bestscoreText;
    private void Start()
    {
    }
    void Update()
    {
        bestscoreText.text = "YOU BSET : " + Score.getbestScore();
    }
}
