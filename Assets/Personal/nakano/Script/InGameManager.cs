using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameManager : MonoBehaviour
{
	public static IngameManager Instance;

	/// <summary>
	/// ����������
	/// </summary>
	private void Awake()
	{
		if(Instance == null)
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
	private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

	/// <summary>
	/// �X�e�[�^�X�̍X�V
	/// </summary>
	private void updateStatus()
	{

	}
}
