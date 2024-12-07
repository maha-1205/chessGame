using UnityEngine;
using UnityEngine.UI;

public class pauseone : MonoBehaviour
{

    public bool isClicked;
    public Button myBtn;
    public Sprite Play;
    public Sprite Pause;

    public void Click()
    {
        changeState();
    }

    private void changeState()
    {
        isClicked = !isClicked;
        if (isClicked) myBtn.image.sprite = Play;
        else myBtn.image.sprite = Pause;
    }
}
