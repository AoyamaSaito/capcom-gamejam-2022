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
        Debug.Log("最初");
    }
    public void OnExit(Aji owner)
    {
        //なんもしない
    }
    public void FirstOperation(Aji owner)
    {
        owner.NextState();
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
        //除外処理
    }
}
