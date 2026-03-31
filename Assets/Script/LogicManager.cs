using UnityEngine;

public class LogicManager : MonoBehaviour
{
   public GameObject startGameScreen;
   
    private void Start()
    {
        Time.timeScale = 0f;
        startGameScreen.SetActive(true);
    } 
    public void StartGame()
    {
        Time.timeScale = 1f;
        startGameScreen.SetActive(false);
    }
}
