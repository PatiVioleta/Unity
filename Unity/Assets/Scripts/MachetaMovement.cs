using UnityEngine;

public class MachetaMovement : MonoBehaviour
{

    public Rigidbody RB;
    public float sideForce = 10f;

    public void AddForce()
    {
        RB.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
