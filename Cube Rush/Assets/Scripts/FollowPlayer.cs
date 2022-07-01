using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Transform Player;
    void Update()
    {
        transform.position = Player.position + offset;
    }
}
