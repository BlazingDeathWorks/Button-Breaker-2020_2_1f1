using UnityEngine;
using UnityEngine.UI;

public class CombinationI_ButtonClick : MonoBehaviour
{
    public Image combo_confirmation;
    public Image confirm_button;
    public Text confirm_text;
    public Text confirmation_text;
    [HideInInspector]
    public bool Confirmation_IsOn = false;

    // Start is called before the first frame update
    void Start()
    {
        combo_confirmation = GameObject.Find("Combination_Confirmation").GetComponent<Image>();
        confirm_button = GameObject.Find("Confirm Button").GetComponent<Image>();
        confirm_text = GameObject.Find("Confirm Button").GetComponentInChildren<Text>();
        confirmation_text = GameObject.Find("Confirmation Text").GetComponent<Text>();
        combo_confirmation.enabled = false;
        confirmation_text.enabled = false;
        confirm_button.enabled = false;
        confirm_text.enabled = false;
    }

    public void Confirmation_OnSwitch()
    {
        Confirmation_IsOn = !Confirmation_IsOn;
    }

    private void Update()
    {
        if (Confirmation_IsOn == false)
        {
            combo_confirmation.enabled = false;
            confirmation_text.enabled = false;
            confirm_button.enabled = false;
            confirm_text.enabled = false;
        }
        else if(Confirmation_IsOn == true)
        {
            combo_confirmation.enabled = true;
            confirm_button.enabled = true;
            confirmation_text.enabled = true;
            confirm_text.enabled = true;
        }
    }

}

