using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    // "Vector3" is another data type, that stores 3 floats (is useful when recording x, y, z positions)
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
