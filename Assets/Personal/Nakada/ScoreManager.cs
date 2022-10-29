using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    //���v�X�R�A
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

    //�X�R�A���Z
    public void AddScore(int addscore)
    {
        score += addscore;
    }
}
