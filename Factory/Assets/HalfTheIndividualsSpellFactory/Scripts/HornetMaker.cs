using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfTheIndividuals
{
    public class HornetMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public void Start()
        {
        }

        public GameObject Make()
        {
            GameObject newGameObject = Instantiate(this.prefab, this.gameObject.transform);
            return newGameObject;
        }
    }
}
