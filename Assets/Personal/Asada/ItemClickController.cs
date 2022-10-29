using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClickController : MonoBehaviour
{
    [SerializeField]private IStreamable _currentItem = null;//���ݑI�����Ă���A�C�e��

    public void Register(IStreamable target)
    {
        _currentItem = target;
        Debug.Log("���̃^�[�Q�b�g" + _currentItem);
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
