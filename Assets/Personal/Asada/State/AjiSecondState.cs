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
        Debug.Log("2");
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
        owner.NextState();
    }
    public void RemoveOperation(Aji owner)
    {
        //除外処理
    }
}
