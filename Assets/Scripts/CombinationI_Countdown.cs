using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CombinationI_Countdown : MonoBehaviour
{
    private Text Points;
    public Text Countdown;
    [HideInInspector]
    public int CombinationI_Points = 0;
    private int countdown = 30;
    [HideInInspector]
    public bool CombinationI_IsRunning = true;
    private bool F_pressed = false;
    private bool S_pressed = false;
    private bool D_pressed = false;

    void Start()
    {
        Points = GameObject.Find("Points Text").GetComponentInChildren<Text>();
        Countdown = GetComponent<Text>();
        CombinationI_Points = 0;
        Points.text = ("Points: ") + CombinationI_Points;
        countdown = 30;
        Countdown.text = ("Countdown: ") + countdown;
        StartCoroutine(TheCountdown());
    }

    IEnumerator TheCountdown()
    {
        Debug.Log("Starting Countdown");
        CombinationI_IsRunning = true;
        while (CombinationI_IsRunning == true)
        {
            countdown -= 1;
            Countdown.text = ("Countdown: ") + countdown;
            yield return new WaitForSeconds(1f);
            if (countdown <= 0)
            {
                CombinationI_IsRunning = false;
                StopCoroutine("TheCountdown");
                countdown = 0;
                Countdown.text = ("Countdown: ") + countdown;
                Invoke("ReturnToMainPage", 1f);
            }
        }
    }

    void ReturnToMainPage()
    {
        LevelSystem_P1.Total_XP += CombinationI_Points;
        SceneManager.LoadScene(5);
    }

    void Update()
    {
        if(D_pressed == true && CombinationI_IsRunning == true)
        {
            CombinationI_Points += 1;
            Points.text = ("Points: " + CombinationI_Points);
            F_pressed = false;
            S_pressed = false;
            D_pressed = false;
            CombinationI_IsRunning = true;
        }
        if(S_pressed == true && Input.GetKeyDown(KeyCode.D))
        {
            D_pressed = true;
        }
        if(F_pressed == true && Input.GetKeyDown(KeyCode.S))
        {
            S_pressed = true;
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            F_pressed = true;
        }
    }
}
