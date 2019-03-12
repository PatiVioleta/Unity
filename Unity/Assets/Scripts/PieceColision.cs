using UnityEngine;

public class PieceColision : MonoBehaviour
{
    bool atingere = false;
    public AudioSource collSound;
    public Rigidbody RB;
    public ForSound FS;

    void Start()
    {
        collSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision colisionInfo)
    {
        if ((colisionInfo.collider.tag == "Ground" || colisionInfo.collider.tag == "Obstacle" ) && atingere==false)
        {
            if (FS != null && FS.GetSound() == false)
                collSound.Play();
            atingere = true;
            RB.mass = 500f;
        }

    }
}
