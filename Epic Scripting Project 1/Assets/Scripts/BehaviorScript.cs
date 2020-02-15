using UnityEngine;

public class BehaviorScript : MonoBehaviour
{
    public Color onColor = Color.yellow;
    public Color offColor = Color.magenta;
    //Script is based on this tutorial: https://www.youtube.com/watch?v=Z0Z7xc18CcA&list=PLX2vGYjWbI0S9-X2Q021GUtolTqbUBB9B
    //I decided to add a bit of my own scripting at the bottom

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        
        if(Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = onColor;
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Renderer>().material.color = offColor;
        }
    }
}
