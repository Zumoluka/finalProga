using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    [SerializeField]
    private float _damageAcount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerControler>())
        {
            var healthcontroller = collision.gameObject.GetComponent<GeneralHealth>();
            healthcontroller.TakeDamage(_damageAcount);
        }
    }
}
