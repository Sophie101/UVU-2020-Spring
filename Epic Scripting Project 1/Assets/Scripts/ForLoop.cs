using UnityEngine;
using System.Collections;

//This Script was based on this tutorial: https://www.youtube.com/watch?v=Jefkb3Gm7vE&list=PLX2vGYjWbI0S9-X2Q021GUtolTqbUBB9B&index=5
public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;

    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }

}
