using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemClickController : MonoBehaviour
{
    [SerializeField]private IStreamable _currentItem = null;//現在選択しているアイテム

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
