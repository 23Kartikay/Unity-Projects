using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject RefCam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = RefCam.transform.position + new Vector3 (0,0,-10);
    }
}
