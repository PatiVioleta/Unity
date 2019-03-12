using UnityEngine;

public class ObstacolMovement : MonoBehaviour
{

    public Rigidbody RB;
    public float sideForce = 100f;
    bool ok = false;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(ok==true)
        {
            RB.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    public void ChangeOk()
    {
        ok = true;
    }
}
