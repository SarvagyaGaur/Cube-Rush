
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GM gameManager;
    public void OnTriggerEnter()
    {
        gameManager.LevelComplete();
    }
}
