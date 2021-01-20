using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private int number;
    private string myName;
    private int counter;
    

    // Start is called before the first frame update
    void Start()
    {
        number = 1;
        myName = "Dane";
        print("Hello " + myName + ", your number is " + number);

        int localVariable = 3;
        print("local variable: " + localVariable);

        counter = 0;

        myFirstMethod();
        
        mySecondMethod("Patrick");
        myThirdMethod("Wilhelm", "Soelberg");

        int myAge = calculateAge(1997);
        print("Your age is " + myAge);
    }

    // Update is called once per frame
    void Update()
    {
        //print(myName);
        //print("local variable: " +localVariable);
        
        counter = counter + 1;
        //print("counter = "+counter);
    }

    public void myFirstMethod()
    {
        print("Hello World");
    }

    public void mySecondMethod(string name)
    {
        print("Hello, your name is " +name);
    }

    public void myThirdMethod(string fName, string lName)
    {
        print("Hello, your name is " + fName + " " +lName);
    }

    public int calculateAge (int YOB)
    {
        int age;
        age = 2021 - YOB;
        return (age);
    }
}
