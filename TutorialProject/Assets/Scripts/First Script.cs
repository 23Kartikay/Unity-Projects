using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class NewBehaviourScript : MonoBehaviour
{
    public int value;
    public string name;
    public GameObject Cube;
    public Vector3 Position;
    public SecondScript secondScript;
    // Start is called before the first frame update
    void Start()
    {
        value = 10;
        Debug.Log(value);
        Debug.Log(name);
        Position = new Vector3(5, 0, 0);
        //Cube.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
    }
    public void BtnClick()
    {
        Cube.SetActive(true);
        Cube.transform.position = Position;
        secondScript.DoChange();
    }
}
