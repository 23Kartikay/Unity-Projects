using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Vector3 mpdpos;
    Vector3 mrpos;
    Vector3 tdes;
    Rigidbody rb;
    bool isShoot;
    Ray r1, r2;
    Manager m;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        m = FindObjectOfType<Manager>();
    }
    void OnMouseDown()
    {
        mpdpos= Input.mousePosition;
        r1=Camera.main.ScreenPointToRay(mpdpos);
    }
    void OnMouseUp()
    {
        mrpos= Input.mousePosition; 
        r2= Camera.main.ScreenPointToRay(mrpos);
        RaycastHit hitresult;
        Physics.Raycast(r2,out hitresult);
        tdes = hitresult.point;
        Raycastshoot();
    }

    void Raycastshoot()
    {
        if (isShoot)
            return;
        isShoot = true;
        rb.AddForce(new Vector3(tdes.x,tdes.y,tdes.z)*160f);
        m.trycount = m.trycount+1;
        Destroy(gameObject,2);
    }
}
