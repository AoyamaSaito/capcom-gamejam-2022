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
        Debug.Log("ç≈èâ");
    }
    public void OnExit(Aji owner)
    {
        //Ç»ÇÒÇ‡ÇµÇ»Ç¢
    }
    public void FirstOperation(Aji owner)
    {
        owner.NextState();
    }
    public void SecondOperation(Aji owner)
    {
        //Ç»ÇÒÇ‡ÇµÇ»Ç¢
    }
    public void ThirdOperation(Aji owner)
    {
        //Ç»ÇÒÇ‡ÇµÇ»Ç¢
    }
    public void RemoveOperation(Aji owner)
    {
        //èúäOèàóù
    }
}
