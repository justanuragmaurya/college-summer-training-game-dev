using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{   
    [SerializeField] Transform player;
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
