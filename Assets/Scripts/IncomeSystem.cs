using System.Collections;
using UnityEngine;

public class IncomeSystem : MonoBehaviour
{
    private Countdown_System countdown_System;
    public static float Income_Rate = 30;
    public static int Income_Earnings = 5;
    [HideInInspector]
    public bool Income_IsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        countdown_System = GameObject.Find("Start&Stop_Countdown").GetComponent<Countdown_System>();
    }

    IEnumerator Income()
    {
        Income_IsRunning = false;
        yield return new WaitForSeconds(Income_Rate);
        BronzeItem_System.Total_Clickpoints += Income_Earnings;
        Income_IsRunning = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(countdown_System.Countdown_IsOn == false)
        {
            Income_IsRunning = true;
            StopCoroutine("Income");
        }
        else if(countdown_System.Countdown_IsOn == true && Income_IsRunning == true)
        {
            StartCoroutine("Income");
        }
    }
}
