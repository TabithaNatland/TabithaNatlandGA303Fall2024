using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitten : MonoBehaviour
{
    // Script #1: Spelling out the word "KITTEN" 

    public char soft = 'k';
    public char warm = 'i';
    public char little = 't';
    public char ball = 'e';
    public char fur = 'n';


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(soft.ToString() + warm.ToString() + little.ToString() + little.ToString() + ball.ToString() + fur.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
