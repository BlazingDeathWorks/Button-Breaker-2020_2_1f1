using UnityEngine;
using UnityEngine.UI;

public class AllCompsInScreen_DisabledCheck : MonoBehaviour
{
    public Image levelscreen;
    public GameObject[] Gameobjects = new GameObject[2];
    [SerializeField]
    private Text RankedPowerUp_Text;


    private void Awake()
    {
        foreach(GameObject gameobjects in Gameobjects)
        {
            gameobjects.SetActive(false);
        }
    }

    private void Start()
    {
        levelscreen = GetComponent<Image>();
        RankedPowerUp_Text = gameObject.GetComponentInChildren<Text>();
    }

    void Update()
    {
        if(levelscreen.enabled == false)
        {
            RankedPowerUp_Text.enabled = false;
            foreach(GameObject gameobjects in Gameobjects)
            {
                gameobjects.SetActive(false);
            }
        }
        else
        {
            RankedPowerUp_Text.enabled = true;
            foreach (GameObject gameobjects in Gameobjects)
            {
                gameobjects.SetActive(true);
            }
        }
    }
}
