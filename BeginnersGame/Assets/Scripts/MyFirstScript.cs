using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private int number;
    private string myName;
    

    // Start is called before the first frame update
    void Start()
    {
        number = 1;
        myName = "Dane";
        
        print("Hello " + myName + ", your number is " + number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
