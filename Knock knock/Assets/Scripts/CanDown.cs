using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDown : MonoBehaviour
{
    bool check = false;
    Manager m;

    // Start is called before the first frame update
    void Start()
    {
        m= FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.up.y < 0.5f && check==false)
        {
            m.cancount= m.cancount+1;
            check = true;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="MyGround" && check ==false)
        {
            m.cancount = m.cancount + 1;
            check = true;
        }
    }
}
