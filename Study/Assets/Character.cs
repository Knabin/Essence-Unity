using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //public Booster booster;
    public delegate void Boost(Character target);
    //public Boost playerBoost;
    public event Boost playerBoost;

    public string playerName = "Nabin";
    public float hp = 100;
    public float defense = 50;
    public float damage = 30;

    // private void Awake() 
    // {
    //     booster.HealthBoost(this);
    // }

    private void Start() 
    {
        playerBoost(this);
    }

    private void Update() 
    {
        if(Input.GetKey(KeyCode.Space))
        {
            playerBoost(this);
        }
    }
}
