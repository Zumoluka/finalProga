using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class ScoreController : MonoBehaviour
{

    public UnityEvent OnScoreChange;
    public int Score { get; private set;}
    public void AddScore(int amount)
    {
        Score += amount;
        OnScoreChange.Invoke();
        if (Score == 100000)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
