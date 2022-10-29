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
            AddScore();
        }

        scoreText.text = "Score : " + score;
    }

    //�X�R�A���Z
    public void AddScore()
    {
        score += addScore;
    }
}
