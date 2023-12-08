using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNearBy : MonoBehaviour
{
     public bool AwearOfPlayer { get; private set; }

    public Vector2 DirectionToPLayer { get; private set; }
    [SerializeField] private float _playerAwarenessDistance;
    private Transform _player;

    public void Awake()
    {
        _player = FindObjectOfType<PLayerControler2>().transform;
    }


    void Update()
    {
        Vector2 enemytoPlayer = _player.position - transform.position;
        DirectionToPLayer = enemytoPlayer.normalized;
        if (enemytoPlayer.magnitude <= _playerAwarenessDistance)
        {
            AwearOfPlayer = true;
        }
        else 
        { 
            AwearOfPlayer = false;
        }
    }
}
