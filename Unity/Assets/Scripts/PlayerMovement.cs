using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody RB;
    public PlayerColision PC;
    public float forwardForce = 1500f;
    public float sideForce = 100000f;
    public float speed = 10f;

    public float speed2 = 10f;


    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RB.AddForce(0, 0, forwardForce * Time.deltaTime);
        //float hInput = CrossPlatformInputManager.GetAxis("Horizontal")*speed2;
        //RB.AddForce(hInput,0,0);

    }

    public void MoveLeft()
    {
        RB.velocity = new Vector3(-speed, 0, RB.velocity.z);
        //if (PC.EPereteleAtinsS() == false)    RB.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }

    public void MoveRight()
    {
        RB.velocity = new Vector3(speed, 0, RB.velocity.z);
        //if (PC.EPereteleAtinsD() == false)    RB.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }

    public void SetVelocityZero()
    {
        //RB.velocity = new Vector3(0, 0, RB.velocity.z);
    }

}
