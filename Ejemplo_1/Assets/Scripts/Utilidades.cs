using packagePersona;
using packagePuntos;
using System.Collections.Generic;
using System.IO;
using UnityEngine;




[System.Serializable]
public class ListaEstudiantes
{
    public List<Estudiante> estudiantes;
    public ListaEstudiantes(List<Estudiante> estudiantes)
    {
        this.estudiantes = estudiantes;
    }
}

public class ListaPuntos
{
    public List<Punto2D> puntos;
    public ListaPuntos(List<Punto2D> puntos)
    {
        this.puntos = puntos;
    }
}

public static class Utilidades
{
    private static string rutaBase = Application.persistentDataPath + "/";
    public static void GuardarEstudiantes(List<Estudiante> estudiantes, string nombreArchivo = "Estudiantes.json")
    {
        string ruta = rutaBase + nombreArchivo;
        string json = JsonUtility.ToJson(new ListaEstudiantes(estudiantes), true);
        File.WriteAllText(ruta, json);
        Debug.Log(ruta);
    }

    public static void GuardarPuntos(List<Punto2D> puntos, string nombreArchivo = "Puntos.json")
    {
        string ruta = rutaBase + nombreArchivo;
        string json = JsonUtility.ToJson(new ListaPuntos(puntos), true);
        File.WriteAllText(ruta, json);
        Debug.Log(ruta);
    }


}



