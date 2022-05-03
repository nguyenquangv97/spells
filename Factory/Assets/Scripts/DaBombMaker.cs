using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public class DaBombMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public GameObject Make()
        {
            var newGameObject = Instantiate(prefab);
            return newGameObject;
        }
    }
}
