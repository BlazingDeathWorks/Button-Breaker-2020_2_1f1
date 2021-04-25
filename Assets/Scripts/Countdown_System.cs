using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_System : MonoBehaviour
{
    [HideInInspector]
    public bool Countdown_IsOn = false;
    Text Countdown_Butt_Text;
    public static int Countdown_Time;
    public static int Countdown_Current_Time;
    public Text_Ref text_ref;
    private bool Is_Running = true;
    [SerializeField]
    private Button buttonbreaker;
    [SerializeField]
    private Button homebutton;
    [SerializeField]
    private ButtonBreaker_Button durability;
    public float Countdown_Rate = 1;
    public int Countdown_Takaway = 1;
    private void Awake()
    {
        Countdown_Butt_Text = GetComponentInChildren<Text>();
        text_ref = GetComponentInChildren<Text_Ref>();
        Countdown_Time = 60;
        Countdown_Current_Time = Countdown_Time;
        text_ref.Actual_textref.text = "Countdown: " + Countdown_Current_Time;
        buttonbreaker = GameObject.Find("Button Breaker").GetComponent<Button>();
        homebutton = GameObject.Find("Home Button").GetComponent<Button>();
        buttonbreaker.interactable = false;
        durability = GameObject.Find("Button Breaker").GetComponent<ButtonBreaker_Button>();
        homebutton.enabled = true;
    }

    private void Update()
    {
        if(durability.Button_CurrentDurability <= 0)
        {
            Countdown_IsOn = false;
        }
        if(Countdown_Current_Time <= 0)
        {
            StopCoroutine("Countdown_Sequence");
            Is_Running = false;
            Countdown_Rate = 5;
            Countdown_Takaway = 0;
            Countdown_Current_Time = 0;
            text_ref.Actual_textref.text = "Countdown: " + Countdown_Current_Time;
            buttonbreaker.interactable = false;
            homebutton.interactable = false;
        }
       else if(Countdown_IsOn == false)
        {
            Is_Running = true;
            StopCoroutine("Countdown_Sequence");
            Countdown_Butt_Text.text = "Start Countdown";
            homebutton.interactable = true;
            buttonbreaker.interactable = false;
        }
        else if(Countdown_IsOn == true && Is_Running == true)
        {
            StartCoroutine("Countdown_Sequence");
            buttonbreaker.interactable = true;
            homebutton.interactable = false;
        }
        else 
        {
            Countdown_Butt_Text.text = "Stop Countdown";
            text_ref.Actual_textref.text = "Countdown: " + Countdown_Current_Time;
            homebutton.interactable = false;
            buttonbreaker.interactable = true;
           
        }
        
    }

    IEnumerator Countdown_Sequence()
    {
        Is_Running = false;
        Countdown_Current_Time -= Countdown_Takaway;
        text_ref.Actual_textref.text = "Countdown: " + Countdown_Current_Time;
        yield return new WaitForSeconds(Countdown_Rate);
        Is_Running = true;
    }
    
    public void Change_Countdown_Text()
    {
        Countdown_IsOn = !Countdown_IsOn;
    }
}
