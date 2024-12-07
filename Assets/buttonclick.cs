using UnityEngine;
using UnityEngine.UI;

public class buttonclick : Button
{
    //private GameManager gameManager = new GameManager();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        



    }

    

    


     void OnClick()
    {
        GameManager.StopTimer();
    }
}
