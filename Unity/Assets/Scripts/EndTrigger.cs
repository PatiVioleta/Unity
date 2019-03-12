using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameMananger;
    public Scor scor;

    void OnTriggerEnter(Collider colisionInfo)
    {
        if (colisionInfo.tag == "Player")
        {
            scor.ChangeEnd();
            gameMananger.completeLevel();
        }
        
    }
}
