using UnityEngine;
using UnityEngine.UI;

public class LevelSystem_P1 : MonoBehaviour
{
    public Slider XP_slider;
    private int Remaining_Countdown = 0;
    public static int Total_XP = 0;
    public static int XP_Needed = 100;
    public static int Level = 1;
    private int Temp_XP = 0;
    public static int XP_Needed_Equation;

    void Start()
    {
        XP_slider = GetComponent<Slider>();
    }

    void Update()
    {
        XP_Needed_Equation = XP_Needed - Total_XP;
        XP_slider.maxValue = XP_Needed;
        XP_slider.value = Total_XP;
        if(Total_XP >= XP_Needed)
        {
            LevelUp();
        }
    }


    void LevelUp()
    {
        Level += 1;
        Temp_XP = Total_XP - XP_Needed;
        Total_XP = 0;
        XP_Needed += 100;
        Total_XP = Temp_XP;
        Temp_XP = 0;
        XP_slider.value = Total_XP;
        XP_slider.maxValue = XP_Needed;

    }
    public void AddToTotal_XPOnce()
    {
        Remaining_Countdown = Countdown_System.Countdown_Current_Time;
        Total_XP += Remaining_Countdown;
        Remaining_Countdown = 0;
        XP_slider.maxValue = XP_Needed;
        XP_slider.value = Total_XP;
    }
    
}
