using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        Mov();
    }
    public void Mov()
    {
        float transform = Input.GetAxis("Horizontal")* Time.deltaTime * speed;
        float rotation = Input.GetAxis("Vertical") * Time.deltaTime * speed;
    }
}
