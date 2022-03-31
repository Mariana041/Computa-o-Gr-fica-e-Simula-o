



using UnityEngine;

public class Controlodeluzdirecional : MonoBehaviour
{
    //Parte 1

    //coordenadas da luz (variáveis)
    Vector3 rotate = new Vector3(0.1f, 0, 0);
    Light m_Light;
    float rotationSpeed = 4;
    public Color[] cores = new Color[3];

   


    // Start is called before the first frame update
    void Start()
    {
        m_Light = GetComponent<Light>(); //colocar no metodo start pois é um calculo pessado para se fazer todos os frames 

        Debug.Log(cores[0]);
        Debug.Log(cores[1]);
        Debug.Log(cores[2]);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotate);
        //transform.Rotate(0.1f, 0, 0);


        //alteração de cor por do sol: cores amarelo, branco, laranja (Parte 2)

        if (cores.Length == 0)
        {
            Debug.LogWarning("Lista de cores");
            return;
        }

        if (transform.localEulerAngles.x <= 45)
        {
            m_Light.color = cores[0];
        }

        if (transform.localEulerAngles.x > 45 && transform.localEulerAngles.x <= 90)
        {
            m_Light.color = cores[1];
        }

        if (transform.localEulerAngles.x > 90 && transform.localEulerAngles.x <= 180)
        {
            m_Light.color = cores[2];
        }



        //Color c = cores[2];
        //GetComponent<Renderer>().material.color = c;


    }
}

//obj. rodar o sol, como um dia, 
// (x:7,y:0,z:0)