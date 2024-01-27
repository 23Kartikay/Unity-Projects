using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public UIManager uimanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision In:"+collision.gameObject.transform.name);
        if(collision.gameObject.tag=="CylinderObs")
        {
            uimanager.LosePanel();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Win")
        {
            uimanager.WinPanel();
        }
    }
}
