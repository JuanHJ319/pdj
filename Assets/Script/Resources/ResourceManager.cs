using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager RManager;
    public int Vegetal, Animal, Pedra, Madeira, Mana, Pessoas, estrelas;
    // Start is called before the first frame update
    void Awake()
    {
        RManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
