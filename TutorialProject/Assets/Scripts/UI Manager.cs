using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject FrontScreen;
    public GameObject GameUI;
    public GameObject Win;
    public GameObject Lose;
    public GameObject Exit;

    public TMP_Text Distance;
    public TMP_Text Timer;
    public float TimerValue;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        FrontScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape"))
        {
            Exit.SetActive(true);   // Application Quit
        }
        TimerValue += Time.deltaTime;
        int value = (int)TimerValue;
        Timer.text = "" + value;
        int DistanceValue=(int)Player.transform.position.z + 29;
        Distance.text = "" + DistanceValue;
    }
    public void ClickContinue()
    {
        DisableAll();
        GameUI.SetActive(true);
    }
    public void WinPanel()
    {
        DisableAll();
        Win.SetActive(true);
    }
    public void LosePanel()
    {
        DisableAll();
        Lose.SetActive(true);
    }
    public void DisableAll()
    {
        FrontScreen.SetActive(false);
        GameUI.SetActive(false);    
        Win.SetActive(false);
        Lose.SetActive(false); 
        Exit.SetActive(false);
    }
    public void OnExit()
    {
        Application.Quit(); 
    }
}
