using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void ChangeScene()
    {
        SceneManager.LoadScene(3);
    }
}
