using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Background_GameOverCheck : MonoBehaviour
{
    [SerializeField]
    private Animator gameover;
    private Button dis_breaker;
    private Button dis_home;
    private void Start()
    {
        gameover = GetComponent<Animator>();
        dis_breaker = GameObject.Find("Button Breaker").GetComponent<Button>();
        dis_home = GameObject.Find("Home Button").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Countdown_System.Countdown_Current_Time <= 0)
        {
            dis_breaker.interactable = false;
            dis_home.interactable = false;
            Invoke("GameOver", 1f);
        }
    }
    void GameOver()
    {
        dis_breaker.interactable = false;
        dis_home.interactable = false;
        gameover.SetBool("GameOver", true);
        gameover.Play("GameOver_BackgroundAnim");
        Invoke("Load_GameOver", 1f);
    }

    void Load_GameOver()
    {
        SceneManager.LoadScene("Game_Over");
    }

}
