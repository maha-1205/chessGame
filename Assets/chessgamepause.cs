using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class chessgamepause : MonoBehaviour
{

    public Button click;

    public string value = "pause";

    public GameManager gameManager = new GameManager();
    private Movement movement ;

    public void Click()
    {

        if (value == "pause")
        {
            this.value = "play";
            GameManager.StopTimer();
        }
        else
        {

            this.value = "pause";
            GameManager.StartTimer();
        }
        
    }

    public void Exit()
    {
        PlayerConnection.instance.DisconnectAll();
        Application.Quit();
    }

}
