using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{

    [SerializeField] int lifes;
    float energy;
    float impact;
    bool alive;
    [SerializeField] string message;

    // Start is called before the first frame update
    void Start()
    {
        print("Hola Mundo");
        lifes = 3;
        message = "Hola one more tiem";

        Impacto();
    }
    
    void Impacto()
    {
        impact = Random.Range(10f, 200f);

        if(impact >= energy)
        {
            lifes--;

            if(lifes == 0)
            {
                message = "Has muerto";
                alive = false;

            }

            else
            {
                message = "Has perdido una vida";
                energy = 100f
            }

        }

        else
        {
            energy -= impact;
        }

        print(message);

        print("Me han impactado con una fuerza de: " + impact);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
