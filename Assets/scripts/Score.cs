using UnityEngine;
using UnityEngine.UI;
using TMPro;		// Declare Text Mesh Pro namespace 

public class Score : MonoBehaviour
{
	private Text score;
	private int scoreAmount;
	public TextMeshProUGUI tmp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		scoreAmount = 0;
		score = GetComponent<Text>();
		
		tmp.text = scoreAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
		score.text = scoreAmount.ToString();
    }

	public void AddScore()
	{
		scoreAmount+=1;
	}

	public string GetScore()
	{
		return scoreAmount.ToString();
	}
}
