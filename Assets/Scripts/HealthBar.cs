using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image _healthBarForeroundImage;

    public void UpdateHealthBAr(GeneralHealth generalHealth)
    {
        _healthBarForeroundImage.fillAmount = generalHealth.RemainingHealthPercentage;
    }
}
