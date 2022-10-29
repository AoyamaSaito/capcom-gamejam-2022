using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    //合計スコア
    public Text scoreText;
    private int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score;
    }

    void Update()
    {
        //確認用
        //if (Input.GetMouseButtonDown(0))
        //{
        //    AddScore(1);
        //}

        scoreText.text = "Score : " + score;
    }

    //スコア加算
    public void AddScore(int addscore)
    {
        score += addscore;
    }
}
