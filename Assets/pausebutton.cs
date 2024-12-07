using UnityEngine;

public class pausebutton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void Click()
    {
        GameManager.StopTimer();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
