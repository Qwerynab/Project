
using UnityEngine;
using TMPro;
public class Text : MonoBehaviour
{

    public Transform Player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
