
public interface IItemCommandState<T> where T : ICommandStateController<T>
{
    void OnEnter(T owner, IItemCommandState<T> prevState);
    void OnExit(T owner);
    void FirstOperation(T owner);
    void SecondOperation(T owner);
    void ThirdOperation(T owner);
    void RemoveOperation(T owner);
}
