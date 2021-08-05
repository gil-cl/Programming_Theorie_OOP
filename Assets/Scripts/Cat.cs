using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private string name;
    private float eatSpeed = 1.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Eat()
    {
        base.Eat();
    }

    public override void MakeNoice()
    {
        // Miauw. 
        base.MakeNoice();
    }

    public string Name
    {
        get
        {
            return name; 
        }
        set
        {
            if (name.Length > 10)
            {
                Debug.Log("Naam te lang"); 
            }
            else
            { 
                // Naam geven. 
                name = value;  
            }
        }
    }
}
