using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewClass : MonoBehaviour
{
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    public UnityEvent uEvent;
    
   
    void Start()
    {
      uEvent.Invoke();
    }


    void Update()
    {
    print((floatNumber));
    }
}
