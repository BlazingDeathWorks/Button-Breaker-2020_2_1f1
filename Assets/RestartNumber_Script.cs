using UnityEngine;
using UnityEngine.UI;
public class RestartNumber_Script : MonoBehaviour
{
    private Text RestartNumber_text;
    // Start is called before the first frame update
    void Start()
    {
        RestartNumber_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("SavedScene") >= 24)
        {
            RestartNumber_text.text = ("Restart Amount: ") + RestartCountdown_System.CountdownReset_CurrentSupply.ToString();
        }
    }
}
