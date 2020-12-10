using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScoreController : MonoBehaviour
{
    public Text scoreText;
    public int totalPoint;

   public void Score()
    {
        totalPoint += 10;
        scoreText.text = totalPoint.ToString();
    }
}
