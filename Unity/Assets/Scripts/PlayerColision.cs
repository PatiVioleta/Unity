using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerColision : MonoBehaviour {

    public PlayerMovement movement;
    public AudioSource collSound;
    public AudioSource collSoundSafe;
    public AudioSource burnSound;
    bool over = false;
    public GameObject bilaSparta;
    public GameObject bilaFlacari;
    public ForSound FS;
    bool pereteAtinsS = false;
    bool pereteAtinsD = false;
    Vector3 offset;

    void Update()
    {
        offset = transform.position;
        if(offset.x>-9 && offset.x<8.9)
        {
            pereteAtinsD = false;
            pereteAtinsS = false;
        }
    }

    void OnCollisionEnter(Collision colisionInfo)
    {

        if(colisionInfo.collider.tag == "Obstacle" && over==false && movement!=null)
        {
            movement.enabled = false;
            over = true;
            Sparge();
            if(SceneManager.GetActiveScene().buildIndex != 0)
                FindObjectOfType<GameManager>().EndGame();
        }

        if (colisionInfo.collider.tag == "Foc" && over == false && movement != null)
        {
            if (FS != null && FS.GetSound() == false)
            {
                burnSound.Play();
                collSound.Play();
            }
            movement.enabled = false;
            over = true;
            Explode();
            if (SceneManager.GetActiveScene().buildIndex != 0)
                FindObjectOfType<GameManager>().EndGame();
        }

        if (colisionInfo.collider.tag == "SafeZone" && over==false)
        {
            if (FS != null && FS.GetSound() == false)
                collSoundSafe.Play();
            //movement.ResetareViteza();
        }

        if (colisionInfo.collider.tag == "Perete" && over == false)
        {
            if (FS != null && FS.GetSound() == false)
                collSoundSafe.Play();
            pereteAtinsS = true;
            pereteAtinsD = false;
            //Debug.Log(transform.position.x.ToString());
        }
       
        if (colisionInfo.collider.tag == "PereteD" && over == false)
        {
            if (FS != null && FS.GetSound() == false)
                collSoundSafe.Play();
            pereteAtinsD = true;
            pereteAtinsS = false;
            //Debug.Log(transform.position.x.ToString());
        }
    }

    void Sparge()
    {
        offset = transform.position;
        offset.Set(offset.x, offset.y / 2, offset.z);
        Instantiate(bilaSparta, offset, Quaternion.identity);
        Destroy(gameObject);
    }

    void Explode()
    {
        offset = transform.position;
        Instantiate(bilaFlacari, offset, transform.rotation);
        offset.Set(offset.x, offset.y / 2, offset.z);
        Instantiate(bilaSparta, offset, Quaternion.identity);
        Destroy(gameObject);
    }

    public bool EPereteleAtinsS()
    {
        return pereteAtinsS;
    }

    public bool EPereteleAtinsD()
    {
        return pereteAtinsD;
    }
}
 