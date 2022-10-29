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
	/// ステージオブジェクト
	/// </summary>
	[SerializeField]
	private GameObject StageDesignObject;
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
	}

	// Start is called before the first frame update
	void Start()
    {
		changeNextPhase(Phase.Title);
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
						BeltConveyor.gameObject.SetActive(false);
					}
					if (StageDesignObject != null)
					{
						// ステージを止める
						//StageDesignObject.SetActive(false);
					}
				}
				break;

			case Phase.InGame:
				{
					if (BeltConveyor != null)
					{
						// ベルトコンベア動かす
						BeltConveyor.gameObject.SetActive(true);
					}
					if (StageDesignObject != null)
					{
						// ステージを動かす
						StageDesignObject.SetActive(true);
					}
				}
				break;

			case Phase.Result:
				{
					if (BeltConveyor != null)
					{
						// ベルトコンベア止める
						BeltConveyor.gameObject.SetActive(false);
					}
					if (StageDesignObject != null)
					{
						// ステージを止める
						//StageDesignObject.SetActive(false);
					}
				}
				break;
		}
	}
}
