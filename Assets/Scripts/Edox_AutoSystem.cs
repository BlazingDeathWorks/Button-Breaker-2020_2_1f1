using System.Collections;
using UnityEngine;

public class Edox_AutoSystem : MonoBehaviour
{
    public static int AutoDamage = 5;
    public static float AutoDamage_Rate = 5;
    // Multiplier multiplies AutoDamage to get more Clickpoints
    public static int AutoDamage_Multiplier = 1;
    private Countdown_System countdown_system;
    private ButtonBreaker_Button ButtonBreaker_Button;
    private bool AutoDamage_IsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        countdown_system = GameObject.Find("Start&Stop_Countdown").GetComponent<Countdown_System>();
        ButtonBreaker_Button = GameObject.Find("Button Breaker").GetComponent<ButtonBreaker_Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown_system.Countdown_IsOn == false)
        {
            AutoDamage_IsRunning = true;
            StopCoroutine("EdoxAuto");
        }
        else if(countdown_system.Countdown_IsOn == true && AutoDamage_IsRunning == true)
        {
            StartCoroutine("EdoxAuto");
        }
    }

    IEnumerator EdoxAuto()
    {
            AutoDamage_IsRunning = false;
            yield return new WaitForSeconds(AutoDamage_Rate);
            ButtonBreaker_Button.Button_CurrentDurability -= AutoDamage * AutoDamage_Multiplier;
            ButtonBreaker_Button.Durability_Text.text = ("Durability: ") + ButtonBreaker_Button.Button_CurrentDurability;
            BronzeItem_System.Total_Clickpoints += AutoDamage;
            AutoDamage_IsRunning = true;
    }

}
