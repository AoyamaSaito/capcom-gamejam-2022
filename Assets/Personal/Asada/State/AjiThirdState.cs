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
        //Ç»ÇÒÇ‡ÇµÇ»Ç¢
    }
    public void FirstOperation(Aji owner)
    {
        //Ç»ÇÒÇ‡ÇµÇ»Ç¢
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
