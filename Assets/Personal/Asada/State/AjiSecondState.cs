using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjiSecondState : IItemCommandState<Aji>
{
    public void OnEnter(Aji owner, IItemCommandState<Aji> prevState)
    {
        if(prevState != this)
        {
            owner.ChangeSprite(Aji.State.Second);
        }
    }
    public void OnExit(Aji owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void FirstOperation(Aji owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void SecondOperation(Aji owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void ThirdOperation(Aji owner)
    {
        owner.NextState();
    }
    public void RemoveOperation(Aji owner)
    {
        owner.DestroyObject();//���O����
    }
}
