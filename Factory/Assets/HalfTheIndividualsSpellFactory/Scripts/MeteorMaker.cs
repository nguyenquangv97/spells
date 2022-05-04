using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfTheIndividuals
{

    public class MeteorMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public GameObject Make()
        {
            var newGameObject = Instantiate(prefab);
            return newGameObject;
        }
    }
}
