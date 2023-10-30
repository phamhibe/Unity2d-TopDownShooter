using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public UnityEvent OnScoreChanged;
    public int Score { get;private set; }
    public void AddSCore(int amount)
    {
        Score += amount;
        OnScoreChanged.Invoke();
    }
}
