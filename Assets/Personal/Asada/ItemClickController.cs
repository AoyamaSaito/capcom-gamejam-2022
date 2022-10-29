using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemClickController : MonoBehaviour
{
    public static ItemClickController instance;


    [SerializeField]private IStreamable _currentItem = null;//���ݑI�����Ă���A�C�e��

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public UnityAction Register(IStreamable target)
    {
        _currentItem = target;
        return () => _currentItem = null;
    }

    public void FirstProcess()
    {
        _currentItem?.FirstProcess();
    }

    public void SecondProcess()
    {
        _currentItem?.SecondProcess();
    }

    public void ThirdProcess()
    {
        _currentItem?.ThirdProcess();
    }

    public void RemoveProces()
    {
        _currentItem?.Remove();
    }


}
