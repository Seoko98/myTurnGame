using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        float x = 4.0f;
        float y = 0.5f;
        float z = 0.0f;

        this.transform.position.Set(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
