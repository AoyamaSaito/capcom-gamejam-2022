using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommandStateController<T> where T : ICommandStateController<T>
{
    void NextState();
}
