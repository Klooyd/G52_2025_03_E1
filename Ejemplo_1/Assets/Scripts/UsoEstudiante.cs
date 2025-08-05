using UnityEngine;
using System.Collections.Generic;
using packagePersona;
using packagePuntos;


namespace packagePuntos
{
    public class UsoEstudiante : MonoBehaviour
    {
        List<Estudiante> listaE = new List<Estudiante>();
        List<Punto2D> listaP = new List<Punto2D>();
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Estudiante e1 = new Estudiante("2220860", "Ing.Multimedia", "Kenneth_Lloyd", "kenneth.cortes@uao.edu.co",
                "cra26J#56a-09");
            Estudiante e2 = new Estudiante("3331759", "Ing.Unimedia", "Llenneth_Kloyd", "Llenneth.descortes@oau.edu.co",
                "cl27K#55b-10");

            listaE.Add(e1);
            listaE.Add(e2);

            Punto2D p1 = new Punto2D(1.0, 2.0);
            Punto2D p2 = new Punto2D(3.0, 4.0);

            listaP.Add(p1);
            listaP.Add(p2);

            for (int i = 0; i < listaE.Count; i++)
            {
                Debug.Log("name " + listaE[i].NameP + "Carrera" + listaE[i].NameCarreraE);

            }

            Utilidades.GuardarEstudiantes(listaE);
            Utilidades.GuardarPuntos(listaP);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
