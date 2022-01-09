using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Print<int>(123);
        Print<string>("Hello World!");

        GetComponent<Rigidbody>();


        Container<string> container = new Container<string>();
        container.messages = new string[3];
        container.messages[0] = "Hello";
        container.messages[1] = "Word";
        container.messages[2] = "Generic";

        for (int i = 0; i < container.messages.Length; ++i)
        {
            Debug.Log(container.messages[i]);
        }

        List<string> list;
    }

    // public void Print(int inputMessage)
    // {
    //     Debug.Log(inputMessage);
    // }

    // public void Print(string inputMessage)
    // {
    //     Debug.Log(inputMessage);
    // }
    
    public void Print<T>(T inputMessage)
    {
        Debug.Log(inputMessage);
    }
}

public class Container<T>
{
    public T[] messages;
}
