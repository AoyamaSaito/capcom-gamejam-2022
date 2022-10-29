using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabDefaultState : IItemCommandState<Crab>
{
    public void OnEnter(Crab owner, IItemCommandState<Crab> prevState)
    {
      
    }
    public void OnExit(Crab owner)
    {
        //Ç»ÇÒÇ‡ÇµÇ»Ç¢
    }
    public void FirstOperation(Crab owner)
    {
        owner.NextState();
    }
    public void SecondOperation(Crab owner)
    {
        owner.NextState();

    }
    public void ThirdOperation(Crab owner)
    {
        owner.NextState();
    }
    public void RemoveOperation(Crab owner)
    {
        owner.DestroyObject();//èúäOèàóù
    }
}
