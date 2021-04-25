using UnityEngine;
using UnityEngine.UI;

public class LevelScreen_OpenClose : MonoBehaviour
{
    [SerializeField]
    private Image level_screen;
    [HideInInspector]
    public bool levelscreen_IsOpen = false;
    private Button levelbutton;
    [SerializeField]
    private Countdown_System Countdown_System;
    // Start is called before the first frame update
    void Start()
    {
        Countdown_System = GameObject.Find("Start&Stop_Countdown").GetComponent<Countdown_System>();
        level_screen = GameObject.Find("Level Screen").GetComponent<Image>();
        levelbutton = GetComponent<Button>();
        level_screen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Countdown_System.Countdown_Current_Time <= 0 || Countdown_System.Countdown_IsOn == true)
        {
            levelbutton.interactable = false;
        }
        else
        {
            levelbutton.interactable = true;
        }
        if(levelscreen_IsOpen == false)
        {
            level_screen.enabled = false;
        }
        else if(levelscreen_IsOpen == true)
        {
            level_screen.enabled = true;
        }
    }

   public void Levelscreen_openclose()
    {
        levelscreen_IsOpen = !levelscreen_IsOpen;
    }

}
