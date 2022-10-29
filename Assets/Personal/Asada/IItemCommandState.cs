
public interface IItemCommandState
{
    void OnEnter(ICommandStateController owner, IItemCommandState prevState);
    void OnExit(ICommandStateController owner);
}
