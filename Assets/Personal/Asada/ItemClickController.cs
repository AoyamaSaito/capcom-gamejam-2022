using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClickController : MonoBehaviour
{
    [SerializeField]private IStreamable _currentItem = null;//現在選択しているアイテム

    public void Register(IStreamable target)
    {
        _currentItem = target;
        Debug.Log("今のターゲット" + _currentItem);
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
