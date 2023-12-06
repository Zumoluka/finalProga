using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamageInvencibility : MonoBehaviour
{
    [SerializeField]
    private float _invincibilityDuration;

    private PLayerInvencibility _invincibilityController;

    private void Awake()
    {
        _invincibilityController = GetComponent<PLayerInvencibility>();
    }

    public void StartInvincibility()
    {
        _invincibilityController.StartInvincibility(_invincibilityDuration);
    }
}
