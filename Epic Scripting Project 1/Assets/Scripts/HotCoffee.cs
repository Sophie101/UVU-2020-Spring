//This script is based on this tutorial: https://www.youtube.com/watch?v=PQihrWCOSic&list=PLX2vGYjWbI0S9-X2Q021GUtolTqbUBB9B&index=4
using UnityEngine;

public class HotCoffee : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }

        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }

        else
        {
            print("Coffee is just right.");
        }
    }
}
