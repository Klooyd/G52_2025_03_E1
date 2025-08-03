using UnityEngine;
using System;
using packagePersona;
using System.Collections.Generic;






public class UsoEstudiante : MonoBehaviour
{
    List<Estudiante> listaE=new List<Estudiante>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Estudiante e1 = new Estudiante("2220860", "Ing.Multimedia", "Kenneth_Lloyd", "kenneth.cortes@uao.edu.co",
            "cra26J#56a-09");
        Estudiante e2 = new Estudiante("3331759", "Ing.Unimedia", "Llenneth_Kloyd", "Llenneth.descortes@uao.edu.co",
            "cl27K#55b-10");

        listaE.Add(e1);
        listaE.Add(e2);


        for (int i = 0; i < listaE.Count; i++)
        {
            Debug.Log("name "+listaE[i].NameP + "Carrera" + listaE[i].NameCarreraE);
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
