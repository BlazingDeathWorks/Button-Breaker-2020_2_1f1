using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class KeyBoard_CombinationLibrary : MonoBehaviour
{
    private ButtonBreaker_Button ButtonBreaker;
    private bool F_Combination1 = false;
    private bool D_Combination1 = false;
    private bool S_Combination1 = false;
    [SerializeField]
    private Countdown_System Countdown_System;


    void Start()
    {
        ButtonBreaker = GetComponent<ButtonBreaker_Button>();
        Countdown_System = GameObject.Find("Start&Stop_Countdown").GetComponent<Countdown_System>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Countdown_System.Countdown_Current_Time == 45 && Countdown_System.Countdown_IsOn == true)
        {
            F_Combination1 = true;
        }
        else if(Input.GetKeyDown(KeyCode.S) && F_Combination1 == true && Countdown_System.Countdown_Current_Time == 45 && Countdown_System.Countdown_IsOn == true)
        {
            S_Combination1 = true;
        }
        else if(Input.GetKeyDown(KeyCode.D) && S_Combination1 == true && Countdown_System.Countdown_Current_Time == 45 && Countdown_System.Countdown_IsOn == true)
        {
            D_Combination1 = true;
        }
        else if(D_Combination1 == true && Countdown_System.Countdown_Current_Time == 45 && Countdown_System.Countdown_IsOn == true)
        {
            CombinationI(5);
        }
    }

    void CombinationI(int CombinationI_Damage)
    {
        ButtonBreaker.Button_CurrentDurability -= CombinationI_Damage;
        ButtonBreaker.Durability_Text.text = ("Durability: ") + ButtonBreaker.Button_CurrentDurability.ToString();
        F_Combination1 = false;
        S_Combination1 = false;
        D_Combination1 = false;
    }

}
