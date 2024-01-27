using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver : MonoBehaviour
{
    public Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    public Color32 noPackageColor = new Color32(1, 1, 1, 1);
    
    bool haspackage;
    public float Desdelay = 0.5f;
    SpriteRenderer spriteRenderer; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Package" && !haspackage)
        {
            Debug.Log("Package picked up.");
            haspackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, Desdelay);
        }
        if (collision.tag == "Customer" && haspackage)
        {
            Debug.Log("Package Delivered.");
            haspackage = false;
            spriteRenderer.color = noPackageColor;  
        }
    }
}
