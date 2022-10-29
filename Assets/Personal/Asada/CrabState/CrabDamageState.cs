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
        //なんもしない
    }
    public void FirstOperation(Crab owner)
    {
        //なんもしない
    }
    public void SecondOperation(Crab owner)
    {
        //なんもしない
    }
    public void ThirdOperation(Crab owner)
    {
        //なんもしない
    }
    public void RemoveOperation(Crab owner)
    {
        //なんもしない
    }


}
