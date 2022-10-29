using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClickController : MonoBehaviour
{
    private IStreamable _currentItem = null;//現在選択しているアイテム

    public void FirstProcess()
    {
        _currentItem.FirstProcess();
    }

    public void SecondProcess()
    {
        _currentItem.SecondProcess();
    }

    public void ThirdProcess()
    {
        _currentItem.ThirdProcess();
    }

    public void RemoveProces()
    {
        _currentItem.Remove();
    }


}
