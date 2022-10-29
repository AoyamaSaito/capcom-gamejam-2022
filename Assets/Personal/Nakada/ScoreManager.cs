using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    //合計スコア
    public Text scoreText;
    public int addScore;
    private int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddScore(addScore);
        }

        scoreText.text = "Score : " + score;
    }

    //スコア加算
    public void AddScore(int addscore)
    {
        score += addscore;
    }
}
