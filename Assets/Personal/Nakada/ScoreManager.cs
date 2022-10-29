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
    private int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score;
    }

    void Update()
    {
        //�m�F�p
        //if (Input.GetMouseButtonDown(0))
        //{
        //    AddScore(1);
        //}

        scoreText.text = "Score : " + score;
    }

    //�X�R�A���Z
    public void AddScore(int addscore)
    {
        score += addscore;
    }
}
