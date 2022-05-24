using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTools
{
    public class Summoner : MonoBehaviour
    {
        [SerializeField]
        bool summonOnStart = false;
        [SerializeField]
        GameObject gameObjectToSummon;
        public void Summon()
        {
            Instantiate(gameObjectToSummon);
        }
        private void Start()
        {
            if (summonOnStart)
            {
                Summon();
            }
        }
    }

}
