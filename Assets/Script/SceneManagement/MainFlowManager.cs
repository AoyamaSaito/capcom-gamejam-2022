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
	/// �X�e�[�W�I�u�W�F�N�g
	/// </summary>
	[SerializeField]
	private GameObject StageDesignObject;
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
	}

	// Start is called before the first frame update
	void Start()
    {
		changeNextPhase(Phase.Title);
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
						BeltConveyor.gameObject.SetActive(false);
					}
					if (StageDesignObject != null)
					{
						// �X�e�[�W���~�߂�
						//StageDesignObject.SetActive(false);
					}
				}
				break;

			case Phase.InGame:
				{
					if (BeltConveyor != null)
					{
						// �x���g�R���x�A������
						BeltConveyor.gameObject.SetActive(true);
					}
					if (StageDesignObject != null)
					{
						// �X�e�[�W�𓮂���
						StageDesignObject.SetActive(true);
					}
				}
				break;

			case Phase.Result:
				{
					if (BeltConveyor != null)
					{
						// �x���g�R���x�A�~�߂�
						BeltConveyor.gameObject.SetActive(false);
					}
					if (StageDesignObject != null)
					{
						// �X�e�[�W���~�߂�
						//StageDesignObject.SetActive(false);
					}
				}
				break;
		}
	}
}
