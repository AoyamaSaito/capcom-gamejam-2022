using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabDamageState : IItemCommandState<Crab>
{
    public void OnEnter(Crab owner, IItemCommandState<Crab> prevState)
    {
        owner.StartDie();
    }
    public void OnExit(Crab owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void FirstOperation(Crab owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void SecondOperation(Crab owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void ThirdOperation(Crab owner)
    {
        //�Ȃ�����Ȃ�
    }
    public void RemoveOperation(Crab owner)
    {
        //�Ȃ�����Ȃ�
    }


}
