using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aji : MonoBehaviour,IStreamable, ICommandStateController
{
    [SerializeField,Header("頭落とした画像")] private Sprite _firstSprite = null;
    [SerializeField, Header("鱗落とした画像")] private Sprite _secondSprite = null;
    [SerializeField,Header("身を開いた画像")] private Sprite _thirdSprite = null;
    private SpriteRenderer _sprite = null;

    private List<ICommandStateController> _stateList = new List<ICommandStateController>();

    void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }
    public void FirstProcess()
    {

    }

    public void SecondProcess()
    {

    }

    public void ThirdProcess()
    {

    }

    public void Remove()
    {

    }

    public void NextState()
    {
        
    }

    public void OnClick()
    {
        
    }
}
