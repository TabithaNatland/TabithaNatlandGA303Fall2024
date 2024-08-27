using System.Collections;
using System.Collections.Generic;
using UnityEngine; // allows us to manipulate unity functions

public class DataTypePractice : MonoBehaviour // class declaration
{
    //WHOLE NUMBERS
    public int num1; // int is 4 bytes - stores whole numbers -2,147,483,648 to +2,147,483,648
    public int num2; // public or private, then datatype, then name

    public long num3; // long is 8 bytes -9,223,372,036,854,775,808 to +9,223,372,036,854,775,808

    public uint num4; // uint is still 4 bytes - allows up to ~4.29 billion (POSITVE ONLY)
    public ulong num5; // ulong is still 8 bytes - allows up to ~18.4 quintillion (POSITVE ONLY)

    //DECIMALS
    public float num6 = 3.1415f; // float is 4 bytes - stores decimal numbers up to 6-7 digits
    public double num7 = 3.14159265; // double is 8 bytes - stores decimal numbers up to 15-16 digits for more precision

    //TRUE OR FALSE
    public bool isProgramingHard = true; // bool is only 1 bit - only stores true/false (or technically, 0/1)

    //DATA SIZES
    //1 byte = 8 bits;
    //1024 bytes = 1 kilobyte KB
    //1024 kilobytes = 1 megabyte MB
    //1024 megabyte = 1 gigabyte GB
    //1024 gigabytes = 1 terabyte TB

    //300Mbps - this is not 300MBps - this is 300 megabits per second
    //1 gigabit internet = download speed of 125 megabytes per second max

    //TEXT VARIABLES
    public char charizard = 'a'; // char contains a character 
    public char blastoise = 'b';
    public char venusaur = 'c';

    public string monsters = "Pokemon is cool, but so is Undertale, " +
        "so I wanted to refer to it here anyway, but now this is getting long, " +
        "but I'll show that it's ok to do this by showing something else shortly.";

    // THESE ARE DATATYPES?
    public Light light;
    public Transform transform; 


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The starting number for num1 is: " + num1); // Debug.Log() will display 
        num1 = num1 + 1;
        Debug.Log("The end number for num1 after adding 1 is: " + num1);

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(DisplayCharizard)
    }

    void DisplayCharizard() //This is a function that can be called in other areas that will run the code in here at the place it was called.
    {
        Debug.Log(charizard);
    }
}
