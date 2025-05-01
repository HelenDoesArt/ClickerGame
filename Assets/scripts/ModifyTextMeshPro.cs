using UnityEngine;
using TMPro;
using UnityEditor.UI;

public class ModifyTextMeshPro : MonoBehaviour
{
    public TMP_Text scoreText;
    private int scoreAmount;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreAmount = 0;
        scoreText.text = "";
    }
    
    public void AddScore()
    {
        scoreAmount+=1;
        scoreText.text = scoreAmount.ToString();
    }
}
