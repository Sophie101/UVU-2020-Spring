
using UnityEngine;

public class IfStatement : MonoBehaviour
{
    public int a =10;
    public int b = 4;
    public int c = 14;
    public string password = "0u812";
    public bool canRun = true;

    void Start()
    {
        if (a+b != c)
        {
            print("That is true");
        }

        if (password == "0u812")
        {
            print("That is the correct password");
        }

        if (!canRun)
        {
            print("We can't run but we can hide");
        }
    }

    void Update()
    {
        
    }
}
