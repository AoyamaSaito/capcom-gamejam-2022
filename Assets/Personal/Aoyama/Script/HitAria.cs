using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAria : MonoBehaviour
{
    [SerializeField]
    private int _doneScore = 1000;
    [SerializeField]
    private int _notDoneScore = 100;

    private ScoreManager _scoreManager;

    private void Start()
    {
        _scoreManager = ScoreManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hit(collision);
    }

    private void Hit(Collider2D col)
    {
        col.TryGetComponent(out IStreamable stream);
        Destroy(col.gameObject, 1);

        if (stream == null) return;

        if(stream.IsDone)
        {
            _scoreManager.AddScore(_doneScore);
        }
        else
        {
            _scoreManager.AddScore(_notDoneScore);
        }
    }
}
