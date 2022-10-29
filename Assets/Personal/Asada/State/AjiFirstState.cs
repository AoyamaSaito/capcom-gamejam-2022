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
        Debug.Log("1");
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
        owner.NextState();
        
    }
    public void ThirdOperation(Aji owner)
    {
        //なんもしない
    }
    public void RemoveOperation(Aji owner)
    {
        //除外処理
    }
}
