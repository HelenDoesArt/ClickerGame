using UnityEngine;

public class Clicker : MonoBehaviour
{

[SerializeField] private int counter = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    void onClick()
    {
        counter++; 
        
    }
    // Update is called once per frame
    void Update()
    {
      
    }
    
}
