using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainFlowManager : MonoBehaviour
{
	#region Definition
	public enum Phase
	{
		Title,
		InGame,
		Result,
	}
	#endregion

	#region SerializeField
	/// <summary>
	/// �x���g�R���x�A
	/// </summary>
	[SerializeField]
	private BeltConveyor BeltConveyor;

	/// <summary>
	/// �A�W�t���C�R���x�A�}�l�[�W��
	/// </summary>
	[SerializeField]
	private AjiFryConveyorManager AjiFryConveyorManager;
	#endregion

	public static MainFlowManager Instance;

	private Phase _CurrentPhase = Phase.Title;

	/// <summary>
	/// ����������
	/// </summary>
	private void Awake()
	{
		if (Instance == null)

		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
		changeNextPhase(Phase.Title);
	}

	// Start is called before the first frame update
	void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
		// �X�e�[�g�̍X�V
		updateStatus();
    }

	/// <summary>
	/// �X�e�[�g�̍X�V
	/// </summary>
	private void updateStatus()
	{
		switch(_CurrentPhase)
		{
			case Phase.Title:
				{
					if(Input.GetKeyDown(KeyCode.Space) == false)
					{
						break;
					}
					changeNextPhase(Phase.InGame);
					break;
				}

			case Phase.InGame:
				{
					if (Input.GetKeyDown(KeyCode.Space) == false)
					{
						break;
					}
					changeNextPhase(Phase.Result);
					break;
				}

			case Phase.Result:
				{
					if (Input.GetKeyDown(KeyCode.Space) == false)
					{
						break;
					}
					changeNextPhase(Phase.Title);
					break;
				}
		}
	}

	/// <summary>
	/// ���̃t�F�[�Y�ɐ؂�ւ���
	/// </summary>
	private void changeNextPhase(Phase next)
	{
		_CurrentPhase = next;
		onChangePhase();
	}

	/// <summary>
	/// �t�F�[�Y���؂�ւ�������̏���
	/// </summary>
	private void onChangePhase()
	{
		switch (_CurrentPhase)
		{
			case Phase.Title:
				{
					if (BeltConveyor != null)
					{
						// �x���g�R���x�A�~�߂�
						BeltConveyor.Pause();
					}
					if (AjiFryConveyorManager != null)
					{
						// �X�e�[�W���~�߂�
						AjiFryConveyorManager.enabled = false;
					}
				}
				break;

			case Phase.InGame:
				{
					if (BeltConveyor != null)
					{
						// �x���g�R���x�A������
						BeltConveyor.Resume();
					}
					if (AjiFryConveyorManager != null)
					{
						// �X�e�[�W�𓮂���
						AjiFryConveyorManager.enabled = true;
					}
				}
				break;

			case Phase.Result:
				{
					if (BeltConveyor != null)
					{
						// �x���g�R���x�A�~�߂�
						BeltConveyor.Pause();
					}
					if (AjiFryConveyorManager != null)
					{
						// �X�e�[�W�𓮂���
						AjiFryConveyorManager.enabled = false;
					}
				}
				break;
		}
	}
}
