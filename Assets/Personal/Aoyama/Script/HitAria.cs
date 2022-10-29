using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAria : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hit(collision);
    }

    private void Hit(Collider2D col)
    {
        //col.TryGetComponent<IStreamable>(out IStreamable stream);
        Destroy(col.gameObject);
    }
}
