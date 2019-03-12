using UnityEngine;

public class CameraMov : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    void Update () {
        if(player!=null)
        {
            //Vector3 coord = new Vector3(0, 1, player.position.z);
            //transform.position = coord + offset;
            transform.position = player.position + offset;
        }
	}
}
