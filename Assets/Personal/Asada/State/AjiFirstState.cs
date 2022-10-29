using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjiFirstState : IItemCommandState<Aji>
{
    public void OnEnter(Aji owner, IItemCommandState<Aji> prevState)
    {
        if (prevState != this)
        {
            owner.ChangeSprite(Aji.State.First);
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
        owner.NextState();
        
    }
    public void ThirdOperation(Aji owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void RemoveOperation(Aji owner)
    {
        owner.DestroyObject();//���O����
    }
}
