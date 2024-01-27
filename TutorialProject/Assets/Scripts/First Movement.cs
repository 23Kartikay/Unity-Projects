using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class FirstMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject RefCamera;
    public float speed = 10f;
    public float rspeed = 50f;
    public int TurnValue;
    public int MoveValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveValue == 0)
        {

        }
        if (MoveValue == 1 || MoveValue == -1)
        {
            float tran = MoveValue * speed * Time.deltaTime;
            Player.transform.Translate(0, 0, tran);
            if (TurnValue == 1)
            {
                float rotate = 1 * rspeed * Time.deltaTime;
                Player.transform.Rotate(0, rotate, 0);
            }
            if (TurnValue == -1)
            {
                float rotate = -1 * rspeed * Time.deltaTime;
                Player.transform.Rotate(0, rotate, 0);
            }
            if (TurnValue == 0)
            {

            }
        }
        float playerZ=Player.transform.position.z - 35;
        RefCamera.transform.position = new Vector3(0,17f,playerZ);
    }
    public void TurnHold(int value)
    {
        TurnValue = value;   
    }
    public void MoveHold(int value)
    {
        MoveValue = value;
    }
}