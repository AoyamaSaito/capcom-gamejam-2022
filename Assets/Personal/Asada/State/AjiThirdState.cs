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
    }
    public void OnExit(Aji owner)
    {
        //なんもしない
    }
    public void FirstOperation(Aji owner)
    {
        //なんもしない
    }
    public void SecondOperation(Aji owner)
    {
        //なんもしない
    }
    public void ThirdOperation(Aji owner)
    {
        //なんもしない
    }
    public void RemoveOperation(Aji owner)
    {
        owner.DestroyObject();//除外処理
    }
}
