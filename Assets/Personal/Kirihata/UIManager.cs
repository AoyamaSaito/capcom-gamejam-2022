using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text timeText;
    [SerializeField] Text scoreText;
    [SerializeField] float timeLimit = 120;

    float nowTime;
 
    // Start is called before the first frame update
    void Start()
    {
        nowTime = timeLimit;
    }

    private void FixedUpdate()
    {
        UpdateTime();
    }

    void UpdateTime() 
    {
        if (nowTime > 0)
        {
            nowTime -= Time.fixedDeltaTime * 3;
            SetTimeText(nowTime);
        }
    }

    public void SetTimeText(float time) 
    {
        timeText.text = string.Format("残り時間 {0:0}:{1:00}", Mathf.CeilToInt(time) / 60, Mathf.CeilToInt(time) % 60);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            PushTakeScalesButton();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PushTakeHeadButton();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            PushOpenButton();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            PushThrowButton();
        }
    }

    public void PushTakeScalesButton() 
    { 
    
    }
    public void PushTakeHeadButton()
    {

    }
    public void PushOpenButton()
    {

    }
    public void PushThrowButton()
    {

    }
}
