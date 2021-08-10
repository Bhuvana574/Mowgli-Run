using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int highscore = 0;
    public static Score Instance;
    public void Awake()
    {

        Instance = this;

    }
    // Start is called before the first frame update
    public int coinsscore = 0;
    
    public void IncrementScore()
    {

        coinsscore = coinsscore + 10;
        scoreText.text = "CoinsScore:" + coinsscore;
        print("\n");





    }
  
}
