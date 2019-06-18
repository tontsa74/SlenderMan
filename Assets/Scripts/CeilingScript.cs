using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
