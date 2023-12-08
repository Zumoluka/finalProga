using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScore : MonoBehaviour
{
    [SerializeField]
    private int _killScore;

    private ScoreController _scorecontroller;

    private void Awake()
    {
        _scorecontroller = FindObjectOfType<ScoreController>();
    }


    public void AllocateScore()
    {
        _scorecontroller.AddScore(_killScore);
    }
}
