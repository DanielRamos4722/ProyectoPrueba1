using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{

    [SerializeField] int lifes;
    float energy = 400;
    float impact;
    bool alive = true;
    [SerializeField] string message;

    // Start is called before the first frame update
    void Start()
    {
        print("Hola Mundo");
        lifes = 3;
        message = "Hola one more tiem";

        //Impacto();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive==true)
            {
            Impacto();
            }
    }

    void Impacto()
    {
            impact = Random.Range(10f, 200f);

            if (impact >= energy)
            {
                lifes--;

                if (lifes == 0)
                {
                    message = "Has muerto";
                    alive = false;
                    print(message);
                }

                else
                {
                    message = "Has perdido una vida";
                    energy = 400f;
                    print(message);
                }

            }

            else
        {
            energy -= impact;
            print("Me han impactado con una fuerza de: " + impact);
        }



}


}
