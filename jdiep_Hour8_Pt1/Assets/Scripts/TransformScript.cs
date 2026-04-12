using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // access transform built-in functions = allows us to translate & rotate GameObject

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f, 0f, 0f);
        transform.Rotate(0f, 0f, 1f);
    }

}
