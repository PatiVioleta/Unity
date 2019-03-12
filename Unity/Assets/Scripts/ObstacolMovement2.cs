using UnityEngine;

public class ObstacolMovement2 : MonoBehaviour
{

    public Rigidbody RB;
    bool ok = false;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (ok == true)
        {
            RB.useGravity = true;
        }
    }

    public void ChangeOk()
    {
        ok = true;
    }
}
