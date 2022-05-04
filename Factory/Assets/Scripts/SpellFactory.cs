using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public enum Spells { Fireball, Person, ColorChanger}

    [RequireComponent(typeof(PersonMaker))]
    [RequireComponent(typeof(FireballMaker))]
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
            else if (Spells.Fireball == type)
            {
                var fireball = this.GetComponent<FireballMaker>().Make();
                fireball.transform.position = this.transform.position;
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
                this.BuildSpell(Spells.Fireball);
            }
            else if (Input.GetButtonDown("Fire2"))
            {
                this.BuildSpell(Spells.ColorChanger);
            }
         }

    }

}
