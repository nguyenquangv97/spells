using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfTheIndividuals
{
    public class PersonMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public void Start()
        {

        }

        public GameObject Make()
        {
            Debug.Log("here");
            GameObject newGameObject = (GameObject)Instantiate(this.prefab);
            return newGameObject;
        }
    }
}