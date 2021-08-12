using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoner : MonoBehaviour
{
    [SerializeField]
    bool summonOnStart = false;
    [SerializeField]
    GameObject gameObject;
    public void Summon()
    {
        Instantiate(gameObject);
    }
    private void Start()
    {
        if (summonOnStart)
        {
            Summon();
        }
    }
}
