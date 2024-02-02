using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    Manager m;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        m = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    public void spawnBall()
    {
        if(GameObject.FindGameObjectWithTag("MyBall")==null && m.trycount<5)
        {
            Instantiate(ball,new Vector3(0, 0.273f, -3.336f),Quaternion.identity);
        }
        else
        {
            print("Ball Already Exists.");
        }
    }
}
