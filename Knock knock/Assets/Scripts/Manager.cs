using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int cancount;
    public int trycount;
    bool decisionmade=false;
    public GameObject winp;
    public GameObject losep;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cancount == 15 && decisionmade == false && trycount <= 5)
        {
            StartCoroutine(loadwinpanel());
        }
        else if (cancount < 15 && decisionmade == false && trycount == 5)
        { 
            StartCoroutine(loadlosepanel());
        }
    }
    IEnumerator loadwinpanel()
    {
        yield return new WaitForSeconds(1f);
        winp.SetActive(true);   
        decisionmade = true;
    }
    IEnumerator loadlosepanel()
    {
        yield return new WaitForSeconds(3.5f);
        losep.SetActive(true);
        decisionmade = true;
    }
}
