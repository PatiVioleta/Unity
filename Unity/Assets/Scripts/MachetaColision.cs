using UnityEngine.SceneManagement;
using UnityEngine;

public class MachetaColision : MonoBehaviour
{
    public MachetaMovement movement;
    public AudioSource collSound;
    public GameObject bilaSparta;
    public ForSound FS;
    Vector3 offset;

    void OnCollisionEnter(Collision colisionInfo)
    {

        if (colisionInfo.collider.tag == "Obstacle" && movement != null)
        {
            movement.enabled = false;
            Sparge();
        }

        if (colisionInfo.collider.tag == "SafeZone" && movement != null)
        {
            movement.AddForce();
        }
    }

    void Sparge()
    {
        offset = transform.position;
        offset.Set(offset.x, offset.y / 2, offset.z);
        Instantiate(bilaSparta, offset, transform.rotation);
        Destroy(gameObject);
    }
}
