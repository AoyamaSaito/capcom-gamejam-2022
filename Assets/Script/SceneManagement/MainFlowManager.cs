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
	/// ベルトコンベア
	/// </summary>
	[SerializeField]
	private BeltConveyor BeltConveyor;

	/// <summary>
	/// アジフライコンベアマネージャ
	/// </summary>
	[SerializeField]
	private AjiFryConveyorManager AjiFryConveyorManager;
	#endregion

	public static MainFlowManager Instance;

	private Phase _CurrentPhase = Phase.Title;

	/// <summary>
	/// 初期化処理
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
		// ステートの更新
		updateStatus();
    }

	/// <summary>
	/// ステートの更新
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
	/// 次のフェーズに切り替える
	/// </summary>
	private void changeNextPhase(Phase next)
	{
		_CurrentPhase = next;
		onChangePhase();
	}

	/// <summary>
	/// フェーズが切り替わった時の処理
	/// </summary>
	private void onChangePhase()
	{
		switch (_CurrentPhase)
		{
			case Phase.Title:
				{
					if (BeltConveyor != null)
					{
						// ベルトコンベア止める
						BeltConveyor.Pause();
					}
					if (AjiFryConveyorManager != null)
					{
						// ステージを止める
						AjiFryConveyorManager.enabled = false;
					}
				}
				break;

			case Phase.InGame:
				{
					if (BeltConveyor != null)
					{
						// ベルトコンベア動かす
						BeltConveyor.Resume();
					}
					if (AjiFryConveyorManager != null)
					{
						// ステージを動かす
						AjiFryConveyorManager.enabled = true;
					}
				}
				break;

			case Phase.Result:
				{
					if (BeltConveyor != null)
					{
						// ベルトコンベア止める
						BeltConveyor.Pause();
					}
					if (AjiFryConveyorManager != null)
					{
						// ステージを動かす
						AjiFryConveyorManager.enabled = false;
					}
				}
				break;
		}
	}
}
