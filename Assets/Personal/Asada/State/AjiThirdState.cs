using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjiThirdState : IItemCommandState<Aji>
{
    public void OnEnter(Aji owner, IItemCommandState<Aji> prevState)
    {
        if (prevState != this)
        {
            owner.ChangeSprite(Aji.State.Third);
        }
        Debug.Log("3");
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
        //�Ȃ�����Ȃ�
    }
    public void RemoveOperation(Aji owner)
    {
        //���O����
    }
}
