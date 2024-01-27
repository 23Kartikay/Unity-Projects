using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotspeed = 150; 
    public int movspeed = 20;
    public int slowspeed = 10;
    public int boostspeed = 30;
    
    // Update is called once per frame
    void Update()
    {
        float steeramt = Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        float movamt = Input.GetAxis("Vertical") * movspeed * Time.deltaTime;
        transform.Rotate(0, 0, -steeramt);
        transform.Translate(0, movamt, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            movspeed = boostspeed;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        movspeed = slowspeed;
    }
}
