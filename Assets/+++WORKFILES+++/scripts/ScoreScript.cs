using UnityEngine;
using TMPro;		// Declare Text Mesh Pro namespace 

public class ScoreScript : MonoBehaviour
{
    private string scoreString;
    private int scoreAmount;
    public TextMeshProUGUI tmp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreString = "" + scoreAmount;
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = scoreString;
    }

    public void AddScore()
    {
        scoreAmount++;
        scoreString = "" + scoreAmount;
    }

    
}