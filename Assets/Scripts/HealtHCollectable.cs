using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtCollectableBehaviour : MonoBehaviour, ICollectableBehaviour
{
    [SerializeField]
    private float _healthAmount;
    public void OnCollected(GameObject player)
    {
        player.GetComponent<GeneralHealth>().AddHealth(_healthAmount);
    }
}
