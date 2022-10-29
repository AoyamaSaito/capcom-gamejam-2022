
/// <summary>
/// コンベアを流れるオブジェクトのインターフェース
/// </summary>
public interface IStreamable
{
    public bool IsDone { get; }
    void FirstProcess();
    void SecondProcess();
    void ThirdProcess();
    void Remove();
}