using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTimer : MonoBehaviour
{
    public GameObject bossGameObject;

    void Start()
    {
        Invoke("ActivateBoss", 3f); // Invoca la función ActivateBoss después de 30 segundos
    }

    void ActivateBoss()
    {
        bossGameObject.SetActive(true); // Activa el GameObject del jefe
    }
}
