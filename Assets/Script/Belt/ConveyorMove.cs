using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ConveyorMove : MonoBehaviour
{
    [SerializeField, Tooltip("参照用")]
    private Rigidbody2D _rb;
    [SerializeField, Tooltip("移動スピード")]
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
    /// 右に移動する関数
    /// </summary>
    private void Move()
    {
        _rb.velocity = Vector3.left * _speed;
    }

    /// <summary>
    /// 一定距離進んだらOnEventを呼ぶ
    /// </summary>
    private void CheckDistance()
    {
        float x = _initPosition.x - transform.position.x;

        if (x >= 1.8 && _isInstantiate == false)
        {
            OnEvent();
            _isInstantiate = true;
        }
    }
}
