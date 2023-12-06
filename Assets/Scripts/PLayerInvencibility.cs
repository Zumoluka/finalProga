using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerInvencibility : MonoBehaviour
{
    private GeneralHealth _healthController;

    private void Awake()
    {
        _healthController = GetComponent<GeneralHealth>();
    }

    public void StartInvincibility(float invincibilityDuration)
    {
        StartCoroutine(InvincibilityCoroutine(invincibilityDuration));
    }

    private IEnumerator InvincibilityCoroutine(float invincibilityDuration)
    {
        _healthController.IsInvincible = true;
        yield return new WaitForSeconds(invincibilityDuration);
        _healthController.IsInvincible = false;
    }
}
