using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class code : MonoBehaviour
{
    public int[] intArray0;
    public int[] intArray5 = new int[5];
    public List<string> people = new List<string>() { "Alex", "John", "Misbahu","Phoebe", "Dan" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Console.Write(people);
    }

    // Update is called once per frame
    void Update()
    { 
    
    }


}
