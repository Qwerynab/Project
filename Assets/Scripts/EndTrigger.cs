
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager Gamemanager; 

    void OnTriggerEnter ()
    {
        Gamemanager.EndGame();

    }
}
