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
    private float _speed = 1f;
    [SerializeField]
    private Transform[] _positions;
    public Transform[] Positions => _positions;

    public Action OnEvent;
    public float SpeedMag = 1f;
    public BeltConveyor BeltConveyor;

    private Vector3 _initPosition;
    private bool _isInstantiate = false;

    public bool _isMove = true;

    private void Start()
    {
        _initPosition = transform.position;
        _isInstantiate = false;
        _isMove = true;
    }

    private void Update()
    {
        if (_isMove == false) return;

        Move();
        CheckDistance();
    }

    /// <summary>
    /// 右に移動する関数
    /// </summary>
    private void Move()
    {
        _rb.velocity = Vector3.left * _speed * SpeedMag;
    }

    /// <summary>
    /// 一定距離進んだらOnEventを呼ぶ
    /// </summary>
    private void CheckDistance()
    {
        float x = _initPosition.x - transform.position.x;

        if (x >= 1.8 && _isInstantiate == false)
        {
            if(OnEvent != null)
            {
                OnEvent();
            }
            _isInstantiate = true;
        }
    }

    public void Pause()
    {
        _isMove = false;
        _rb.velocity = Vector2.zero;
        _rb.angularDrag = 0;
    }

    public void Resume()
    {
        _isMove = true;
    }

    private void OnDestroy()
    {
        if(BeltConveyor != null)
        {
            BeltConveyor._conveyors.Remove(this.gameObject);
        }
    }
}
