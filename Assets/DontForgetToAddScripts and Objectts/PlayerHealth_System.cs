using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth_System : MonoBehaviour
{
    [HideInInspector]
    public Text playerhealthtext;
    public static int Player_MaxHealth = 10;
    [HideInInspector]
    public int Player_CurrentHealth;
    public int Player_TakeDamage = 1;
    public float TakeDamage_Rate = 1;
    public Countdown_System countdown_System;
    [HideInInspector]
    public bool PlayerHP_takaway = true;
    [HideInInspector]
    public int HealPerClick = 1;

    private void Awake()
    {
        HealPerClick = 1;
        if (PlayerPrefs.GetInt("SavedScene") < 17 || PlayerPrefs.GetInt("SavedScene") > 17)
        {
            countdown_System.Countdown_Rate = 1;
            countdown_System.Countdown_Takaway = 1;
        }
    }

    void Start()
    {
        playerhealthtext = GetComponent<Text>();
        Player_CurrentHealth = Player_MaxHealth;
        countdown_System = GameObject.Find("Start&Stop_Countdown").GetComponent<Countdown_System>();
        playerhealthtext.text = ("Player HP: ") + Player_CurrentHealth;
    }

    private void Update()
    {
        Countdown_ZeroCondition();
        HP_ZeroCondition();
        HealthEffect_Seq1();
        TakeDamageRate_Condition();
        if(PlayerHP_takaway == true && countdown_System.Countdown_IsOn == true)
        {
            StartCoroutine("Playertaking_damagesequence");
        }
        else if(countdown_System.Countdown_IsOn == false)
        {
            PlayerHP_takaway = true;
            StopCoroutine("Playertaking_damagesequence");
        }
        if(countdown_System.Countdown_IsOn == true && Input.GetKeyDown(KeyCode.S))
        {
            HealPlayerHP();
        }
        else if(countdown_System.Countdown_IsOn == true && Input.GetKeyDown(KeyCode.W))
        {
            if (Player_CurrentHealth <= 0)
            {
                Player_CurrentHealth -= 0;
            }
            else 
            {
                Player_CurrentHealth -= 1;
                playerhealthtext.text = ("Player HP: ") + Player_CurrentHealth;
            }
        }
    }

    void TakeDamageRate_Condition()
    {
        if(TakeDamage_Rate >= 0.7)
        {
            HealPerClick = 1;
        }
        else if(TakeDamage_Rate >= 0.4 && TakeDamage_Rate < 0.7)
        {
            HealPerClick = 2;
        }
        else if(TakeDamage_Rate >= 0.1 && TakeDamage_Rate < 0.4)
        {
            HealPerClick = 3;
        }
    }


    void Countdown_ZeroCondition()
    {
        if (Countdown_System.Countdown_Current_Time <= 0)
        {
            Player_CurrentHealth = 0;
            playerhealthtext.text = ("Player HP: ") + Player_CurrentHealth;
            StopCoroutine("Playertaking_damagesequence");
            PlayerHP_takaway = false;
        }
    }

    void HP_ZeroCondition()
    {
        // if player health <= 0, then we want to bring the countdown to zero, therefore giving us a gameover
        if (Player_CurrentHealth <= 0)
        {
            StopCoroutine("Playertaking_damagesequence");
            PlayerHP_takaway = false;
            Player_CurrentHealth = 0;
            playerhealthtext.text = ("Player HP: ") + Player_CurrentHealth;
            Countdown_System.Countdown_Current_Time = 0;
        }
    }
    void HealthEffect_Seq1()
    {
        // Start of the Health Effect Sequence 1
        if (Player_CurrentHealth >= 8 && PlayerPrefs.GetInt("SavedScene") < 17)
        {
            countdown_System.Countdown_Takaway = 1;
            countdown_System.Countdown_Rate = 0.2f;
        }
        else if (Player_CurrentHealth >= 5 && PlayerPrefs.GetInt("SavedScene") < 17)
        {
            countdown_System.Countdown_Rate = 1;
            countdown_System.Countdown_Takaway = 3;
        }
        else if (Player_CurrentHealth >= 2 && PlayerPrefs.GetInt("SavedScene") < 17)
        {
            countdown_System.Countdown_Takaway = 2;
            countdown_System.Countdown_Rate = 0.5f;
        }
        else if (Player_CurrentHealth == 1 && PlayerPrefs.GetInt("SavedScene") < 17)
        {
            countdown_System.Countdown_Rate = 1;
            countdown_System.Countdown_Takaway = 1;
        }
        // End of the Health Effect Sequence 1, moving on to sequence 2 at the awake function
    }

    // Heals player health by the int, HealPerClick, default is 1
    void HealPlayerHP()
    {
        Player_CurrentHealth += HealPerClick;
        playerhealthtext.text = ("Player HP: ") + Player_CurrentHealth;
        if(Countdown_System.Countdown_Current_Time <= 0)
        {
            HealPerClick = 0;
        }
        if(Player_CurrentHealth > Player_MaxHealth)
        {
            Player_CurrentHealth = Player_MaxHealth;
            playerhealthtext.text = ("Player HP: ") + Player_CurrentHealth;
        }
    }

    // Take damage every second, the "every second" would change after sequence 1
    IEnumerator Playertaking_damagesequence()
    {
        PlayerHP_takaway = false;
        yield return new WaitForSeconds(TakeDamage_Rate);
        Player_CurrentHealth -= Player_TakeDamage;
        playerhealthtext.text = ("Player HP: ") + Player_CurrentHealth;
        PlayerHP_takaway = true;
    }


}
