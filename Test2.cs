using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("helloooooo");

        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int counter = 0;
        string funny_sentence = "";

        while (counter < 7)
        {
            int ward = Random.Range(0,8);
            counter++;
        }

          Debug.Log(funny_sentence); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
