using UnityEngine;

public class movTrigger : MonoBehaviour
{
    public ObstacolMovement obM0;
    public ObstacolMovement obM1;
    public ObstacolMovement obM2;
    public ObstacolMovement obM3;
    public ObstacolMovement obM4;
    public ObstacolMovement obM5;

    void OnTriggerEnter()
    {
        if (obM0 != null)
            obM0.ChangeOk();
        if (obM1 != null)
            obM1.ChangeOk();
        if (obM2 != null)
            obM2.ChangeOk();
        if (obM3 != null)
            obM3.ChangeOk();
        if (obM4 != null)
            obM4.ChangeOk();
        if (obM5 != null)
            obM5.ChangeOk();
    }
}
