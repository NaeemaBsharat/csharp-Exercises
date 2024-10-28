using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        


            
            // Exercise 1: Number Generator:
            while (true)
            {
                int randomNumber = Random.Range(1, 21); 

                if (randomNumber == 5)
                {
                    continue; 
                }
                if (randomNumber == 15)
                {
                    break; 
                }
                Debug.Log(randomNumber);
                
            }

            // Exercise 2: Funny Sentence Generator:

            string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
            int counter = 0;
            string funny_sentence = "";

            while (counter < 7)
            {
                int ward = Random.Range(0,8);
                funny_sentence +=words[ward];
                counter++;
            }

            Debug.Log(funny_sentence); 


         

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
