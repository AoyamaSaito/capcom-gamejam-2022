using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjiDefaultState : IItemCommandState<Aji>
{
    public void OnEnter(Aji owner, IItemCommandState<Aji> prevState)
    {
        if (prevState != this)
        {
            owner.ChangeSprite(Aji.State.Default);
        }
        Debug.Log("�ŏ�");
    }
    public void OnExit(Aji owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void FirstOperation(Aji owner)
    {
        owner.NextState();
    }
    public void SecondOperation(Aji owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void ThirdOperation(Aji owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void RemoveOperation(Aji owner)
    {
        //���O����
    }
}
