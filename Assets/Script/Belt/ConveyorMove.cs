using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ConveyorMove : MonoBehaviour
{
    [SerializeField, Tooltip("�Q�Ɨp")]
    private Rigidbody2D _rb;
    [SerializeField, Tooltip("�ړ��X�s�[�h")]
    private float _speed = 5f;

    public Action OnEvent;

    private Vector3 _initPosition;
    private bool _isInstantiate = false;

    private void Start()
    {
        _initPosition = transform.position;
        _isInstantiate = false;
    }

    private void Update()
    {
        Move();
        CheckDistance();
    }

    /// <summary>
    /// �E�Ɉړ�����֐�
    /// </summary>
    private void Move()
    {
        _rb.velocity = Vector3.left * _speed;
    }

    /// <summary>
    /// ��苗���i�񂾂�OnEvent���Ă�
    /// </summary>
    private void CheckDistance()
    {
        float x = _initPosition.x - transform.position.x;

        if (x >= transform.localScale.x - 0.2 && _isInstantiate == false)
        {
            OnEvent();
            _isInstantiate = true;
        }
    }
}
