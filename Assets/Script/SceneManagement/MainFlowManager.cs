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
		_CurrentPhase = Phase.Title;
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
					SceneManager.LoadScene("InGame");
					_CurrentPhase = Phase.InGame;
					break;
				}

			case Phase.InGame:
				{
					if (Input.GetKeyDown(KeyCode.Space) == false)
					{
						break;
					}
					SceneManager.LoadScene("Title");
					_CurrentPhase = Phase.Title;
					break;
				}
		}
	}
}
