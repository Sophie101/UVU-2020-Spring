using UnityEngine;
using System.Collections;

//This script is based on this tutorial: https://www.youtube.com/watch?v=Jefkb3Gm7vE&list=PLX2vGYjWbI0S9-X2Q021GUtolTqbUBB9B&index=5
public class DoWhileLoop : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print ("Hello World");
        } 
        while (shouldContinue == true);
    }

}
