using UnityEngine;
using UnityEngine.UI;

public class ButtonBreaker_Button : MonoBehaviour
{
    public static int Button_MaxDurability = 75;
    [HideInInspector]
    public int Button_CurrentDurability = Button_MaxDurability;
    public Text Durability_Text;
    [SerializeField]
    private Animator levelcomplete_anim;
    private int Default_Clickdamage;
    private int Bronze_Clickdamage;
    private int Silver_Clickdamage;
    private int Gold_Clickdamage;
    private int Platinum_Clickdamage;
    private int Diamond_Clickdamage;
    public LevelSystem_P1 LevelSystem_P1;
    private bool OneTime;
    [HideInInspector]
    public int SceneNumber;

    private void Awake()
    {
        OneTime = true;
    }

    private void Start()
    {
        Default_Clickdamage = 1;
        Bronze_Clickdamage = 5;
        Silver_Clickdamage = 10;
        Gold_Clickdamage = 15;
        Platinum_Clickdamage = 20;
        Diamond_Clickdamage = 25;
        SceneNumber = PlayerPrefs.GetInt("SavedScene");
        if (SceneNumber <= 49)
        {
            Button_MaxDurability = 75 * SceneNumber;
            Button_CurrentDurability = Button_MaxDurability;
        }
        else
        {
            Button_MaxDurability = 1000000;
            Button_CurrentDurability = Button_MaxDurability;
        }
        Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        levelcomplete_anim = GameObject.Find("Level Complete Background").GetComponent<Animator>();
        Durability_Text = GameObject.Find("Durability_Text").GetComponent<Text>();
    }
    public void ButtonBreaker()
    {
        if(DefaultItem_System.Default_Equipped == true)
        {
            Button_CurrentDurability -= Default_Clickdamage;
            BronzeItem_System.Total_Clickpoints += Default_Clickdamage;
            Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        }
        if(BronzeItem_System.Bronze_Equipped == true)
        {
            Button_CurrentDurability -= Bronze_Clickdamage;
            BronzeItem_System.Total_Clickpoints += Bronze_Clickdamage;
            Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        }
        if (SilverItem_System.Silver_Equipped == true)
        {
            Button_CurrentDurability -= Silver_Clickdamage;
            BronzeItem_System.Total_Clickpoints += Silver_Clickdamage;
            Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        }
        if(GoldItem_System.Gold_Equipped == true)
        {
            Button_CurrentDurability -= Gold_Clickdamage;
            BronzeItem_System.Total_Clickpoints += Gold_Clickdamage;
            Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        }
        if(PlatinumItem_System.Platinum_Equipped == true)
        {
            Button_CurrentDurability -= Platinum_Clickdamage;
            BronzeItem_System.Total_Clickpoints += Platinum_Clickdamage;
            Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        }
        if (DiamondItem_System.Diamond_Equipped == true)
        {
            Button_CurrentDurability -= Diamond_Clickdamage;
            BronzeItem_System.Total_Clickpoints += Diamond_Clickdamage;
            Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        }
        else
        {
            Button_CurrentDurability -= 0;
            Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        }
    }

    private void Update()
    {
        Durability_Text.text = ("Durability: ") + Button_CurrentDurability;
        if(Button_CurrentDurability <= 0)
        {
            Durability_Text.text = ("Durability: ") + 0;
            levelcomplete_anim.SetBool("LevelComplete", true);
            if (OneTime == true)
            {
                LevelSystem_P1.AddToTotal_XPOnce();
                OneTime = false;
            }
        }   
    }

}
