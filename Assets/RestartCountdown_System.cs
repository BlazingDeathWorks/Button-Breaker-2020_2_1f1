using UnityEngine;

public class RestartCountdown_System : MonoBehaviour
{
    public static int CountdownReset_MaxSupply = 1;
    public static int CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
    private Countdown_System Countdown_System;

    void Start()
    {
        Countdown_System = GetComponent<Countdown_System>();
        ResetAmountCondition();
    }

    private void ResetAmountCondition()
    {
        if(PlayerPrefs.GetInt("SavedScene") <= 23)
        {
            CountdownReset_MaxSupply = 0;
            CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
        }
        else if(PlayerPrefs.GetInt("SavedScene") <= 30 && PlayerPrefs.GetInt("SavedScene") >= 24)
        {
            CountdownReset_MaxSupply = 3;
            CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
        }
        else if(PlayerPrefs.GetInt("SavedScene") >= 31 && PlayerPrefs.GetInt("SavedScene") <= 38)
        {
            CountdownReset_MaxSupply = 7;
            CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
        }
        else if(PlayerPrefs.GetInt("SavedScene") >= 39 && PlayerPrefs.GetInt("SavedScene") <= 43)
        {
            CountdownReset_MaxSupply = 9;
            CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
        }
        else if(PlayerPrefs.GetInt("SavedScene") == 44 || PlayerPrefs.GetInt("SavedScene") == 45)
        {
            CountdownReset_MaxSupply = 10;
            CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
        }
        else if(PlayerPrefs.GetInt("SavedScene") == 50)
        {
            CountdownReset_MaxSupply = 1000000;
            CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
        }
        else
        {
            CountdownReset_MaxSupply = 1;
            CountdownReset_CurrentSupply = CountdownReset_MaxSupply;
        }
    }

    // Update is called once per frame
    void Update()
    {
        RestartCountdown();
    }

    void RestartCountdown()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Countdown_System.Countdown_IsOn == true && CountdownReset_CurrentSupply >= 1)
            {
                Countdown_System.Countdown_Current_Time = Countdown_System.Countdown_Time;
                CountdownReset_CurrentSupply -= 1;

            }
        }
    }

}
