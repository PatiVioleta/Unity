using UnityEngine;
using UnityEngine.UI;

public class Scor : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public PlayerMovement movement;
    bool end = false;
    int endCount = 500;


    void Update()
    {
        if(movement!=null)
        {
            if (movement.isActiveAndEnabled == true && player!=null)
                scoreText.text = player.position.z.ToString("0");
            if (end == true && player!=null)
                scoreText.text = endCount.ToString();
        }
    }

    public void ChangeEnd(){ end = true;}
}
