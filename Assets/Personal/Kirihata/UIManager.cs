using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text timeText;
    [SerializeField] Text scoreText;
    [SerializeField] float timeLimit = 120;

    [SerializeField] EventSystem eventsystem;
    [SerializeField] Button takeScalesButton;
    [SerializeField] Button takeHeadButton;
    [SerializeField] Button openButton;
    [SerializeField] Button throwButton;


    float nowTime;
 
    //初期化
    void Start()
    {
        if(eventsystem == null) 
        {
            Debug.LogWarning("eventsystemが設定されていません!",gameObject);
        }
        nowTime = timeLimit;
        SetTimeText(nowTime);

        SetScoreText(0);
    }

    private void FixedUpdate()
    {
        UpdateTime();
    }

    //時間関係の処理
    void UpdateTime() 
    {
        if (nowTime > 0)
        {
            nowTime -= Time.fixedDeltaTime;
            SetTimeText(nowTime);
        }
    }

    //
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            ExecuteEvents.Execute(takeScalesButton.gameObject, new BaseEventData(eventsystem), ExecuteEvents.submitHandler);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ExecuteEvents.Execute(takeHeadButton.gameObject, new BaseEventData(eventsystem), ExecuteEvents.submitHandler);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ExecuteEvents.Execute(openButton.gameObject, new BaseEventData(eventsystem), ExecuteEvents.submitHandler);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ExecuteEvents.Execute(throwButton.gameObject, new BaseEventData(eventsystem), ExecuteEvents.submitHandler);
        }
    }

    //時間の表示を更新
    public void SetTimeText(float time)
    {
        timeText.text = string.Format("残り時間 {0:0}:{1:00}", Mathf.CeilToInt(time) / 60, Mathf.CeilToInt(time) % 60);
    }

    //スコアの表示を更新
    public void SetScoreText(int value)
    {
        scoreText.text = string.Format("¥{0:D}", value);
    }

    //鱗をとる
    public void PushTakeScalesButton() 
    { 
        
    }

    //頭をとる
    public void PushTakeHeadButton()
    {

    }

    //身をひらく
    public void PushOpenButton()
    {

    }

    //はじく
    public void PushThrowButton()
    {

    }
}
