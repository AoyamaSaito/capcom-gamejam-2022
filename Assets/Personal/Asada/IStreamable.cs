
/// <summary>
/// �R���x�A�𗬂��I�u�W�F�N�g�̃C���^�[�t�F�[�X
/// </summary>
public interface IStreamable
{
    public bool IsDone { get; }
    void FirstProcess();
    void SecondProcess();
    void ThirdProcess();
    void Remove();
}