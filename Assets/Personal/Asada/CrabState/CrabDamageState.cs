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
        //‚È‚ñ‚à‚µ‚È‚¢
    }
    public void FirstOperation(Crab owner)
    {
        //‚È‚ñ‚à‚µ‚È‚¢
    }
    public void SecondOperation(Crab owner)
    {
        //‚È‚ñ‚à‚µ‚È‚¢
    }
    public void ThirdOperation(Crab owner)
    {
        //‚È‚ñ‚à‚µ‚È‚¢
    }
    public void RemoveOperation(Crab owner)
    {
        //‚È‚ñ‚à‚µ‚È‚¢
    }


}
