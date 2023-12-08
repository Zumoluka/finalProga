using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _collectablePrfab;

    public void SpawnCollectable(Vector2 position)
    {
        int index = Random.Range(0, _collectablePrfab.Count);
        var selectedCollectable = _collectablePrfab[index];

        Instantiate(selectedCollectable, position, Quaternion.identity);
    }
}
