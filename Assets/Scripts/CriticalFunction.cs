using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CriticalFunction : MonoBehaviour
{
    private Image CritImage;
    private Text CritText;
    public CriticalHit_System CriticalHit_System;
    public ButtonBreaker_Button Durability;
    public static int CriticalDamage = 50;

    void Start()
    {
        CritImage = GetComponent<Image>();
        CritText = GetComponentInChildren<Text>();
        CriticalHit_System = GetComponentInParent<CriticalHit_System>();
        Durability = GetComponentInParent<ButtonBreaker_Button>();
        CriticalHit_System.CriticalHitChance = 2;
        CritImage.enabled = false;
        CritText.enabled = false;
    }
    
    public void CriticalHit()
    {
        Durability.Button_CurrentDurability -= CriticalDamage;
        Durability.Durability_Text.text = ("Durability: ") + Durability.Button_CurrentDurability.ToString();
        CriticalHit_System.CriticalHitChance = 2;
        if (Durability.Button_CurrentDurability <= 0)
        {
            Durability.Button_CurrentDurability = 0;
            Durability.Durability_Text.text = ("Durability: ") + Durability.Button_CurrentDurability.ToString();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(CriticalHit_System.CriticalHitChance == 1)
        {
            CritImage.enabled = true;
            CritText.enabled = true;
        }
        else if(CriticalHit_System.CriticalHitChance != 1)
        {
            CritImage.enabled = false;
            CritText.enabled = false;
        }
    }

}
