using UnityEngine;
using UnityEngine.UI;

public class LevelComplete_TextCheck : MonoBehaviour
{
    [SerializeField]
    private Animator levelcomplete_textanim;
    [SerializeField]
    private Text levelcomplete_text;
    [SerializeField]
    private ButtonBreaker_Button buttonbreaker_button;
    [SerializeField]
    private Text levelcomplete_nextleveltext;
    public Image levelcomplete_nextlevelbutton;

    void Start()
    {
        buttonbreaker_button = GameObject.Find("Button Breaker").GetComponent<ButtonBreaker_Button>();
        levelcomplete_nextleveltext = GameObject.Find("LevelComplete_NextLevelText").GetComponent<Text>();
        levelcomplete_nextlevelbutton = GameObject.Find("LevelComplete_NextLevelButton").GetComponent<Image>();
        levelcomplete_textanim = GetComponent<Animator>();
        levelcomplete_text = GetComponent<Text>();
    }

    void Update()
    {
        if(buttonbreaker_button.Button_CurrentDurability <= 0)
        {
            Invoke("Dolevelcomplete_text", 3f);
            Invoke("DisplayNextLevel_Button", 3.9f);
        }
        else
        {
            levelcomplete_text.enabled = false;
            levelcomplete_nextleveltext.enabled = false;
            levelcomplete_nextlevelbutton.enabled = false;
        }
    }

    void Dolevelcomplete_text()
    {
        levelcomplete_textanim.SetBool("LevelCompleteText_IsReady", true);
        levelcomplete_text.enabled = true;

    }


    void DisplayNextLevel_Button()
    {
        levelcomplete_nextleveltext.enabled = true;
        levelcomplete_nextlevelbutton.enabled = true;
    }

}
