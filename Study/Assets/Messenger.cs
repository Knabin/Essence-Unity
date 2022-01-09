using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public delegate void Send(string reciever);

    Send onSend;

    private void Start() 
    {
        onSend += SendMail;
        onSend += SendMoney;
        
        //onSend += man => Debug.Log("Assainate " + man);
        onSend += (string man) => { 
            Debug.Log("Assainate " + man); 
            Debug.Log("Hide body"); 
        };
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onSend("Nabin");
        }
    }

    void SendMail(string reciever)
    {
        Debug.Log("Mail sent to: " + reciever);
    }
    
    void SendMoney(string reciever)
    {
        Debug.Log("Money sent to: " + reciever);
    }
}
