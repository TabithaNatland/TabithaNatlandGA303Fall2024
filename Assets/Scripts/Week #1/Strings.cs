using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    //Script #3: Take multiple strings and output a Debug.Log() that contains all of those strings in a single debug log.

     public string please = "I don't think I understand scripting.";
     public string help = "I am however, trying my very best.";
     public string me = "Hopefully by the end of the semester this will be a little easier.";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(please + help + me);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
