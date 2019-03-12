using UnityEngine;

public class movTrigger2 : MonoBehaviour
{
    public ObstacolMovement2 obM0;
    public ObstacolMovement2 obM1;
    public ObstacolMovement2 obM2;
    public ObstacolMovement2 obM3;
    public ObstacolMovement2 obM4;
    public ObstacolMovement2 obM5;

    void OnTriggerEnter()
    {
        if(obM0!=null)
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
