using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aji : MonoBehaviour,IStreamable, ICommandStateController
{
    [SerializeField,Header("�����Ƃ����摜")] private Sprite _firstSprite = null;
    [SerializeField, Header("�ؗ��Ƃ����摜")] private Sprite _secondSprite = null;
    [SerializeField,Header("�g���J�����摜")] private Sprite _thirdSprite = null;
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
