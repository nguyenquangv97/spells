using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfTheIndividuals
{
    public enum Spells { Hornet, Person, ColorChanger}

    [RequireComponent(typeof(PersonMaker))]
    [RequireComponent(typeof(HornetMaker))]
    public class SpellFactory : MonoBehaviour
    {
        public void BuildSpell(Spells type)
        {
            if(Spells.Person == type)
            {
                var Person = this.GetComponent<PersonMaker>().Make();
                Person.transform.position = this.transform.position;
                Destroy(Person, 5);
            }
            else if (Spells.Hornet == type)
            {
                var hornet = this.GetComponent<HornetMaker>().Make();
                hornet.transform.position = this.transform.position;
            }
            else if (Spells.ColorChanger == type)
            {
                var colorChanger = this.GetComponent<ColorChangerMaker>().Make();
                colorChanger.transform.position = this.transform.position;
            }
        }

        public void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {

                this.BuildSpell(Spells.Person);
            }
            else if(Input.GetButtonDown("Fire1"))
            {
                this.BuildSpell(Spells.Hornet);
            }
            else if (Input.GetButtonDown("Fire2"))
            {
                this.BuildSpell(Spells.ColorChanger);
            }
         }

    }

}
