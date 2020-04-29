using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showBestscore : MonoBehaviour
{
    public Text bestscoreText;
     void Update()
    {
        bestscoreText.text = Score.bestscoreText;
    }
}
