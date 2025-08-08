using packagePersona;
using packagePuntos;
using System.Collections.Generic;
using System.IO;
using UnityEngine;



[System.Serializable]
public class ListaEstudiantes
{
    public List<Estudiante> estudiantes;
    public ListaEstudiantes(List<Estudiante> e) { estudiantes = e; }
}

[System.Serializable]
public class ListaPuntos
{
    public List<Punto2D> puntos;
    public ListaPuntos(List<Punto2D> p) { puntos = p; }
}

public static class Utilidades
{
    public static void GuardarEstudiantes(List<Estudiante> estudiantes, string nombreArchivo = "Estudiantes.json")
    {
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        string json = JsonUtility.ToJson(new ListaEstudiantes(estudiantes), true);
        File.WriteAllText(ruta, json);
        Debug.Log("Estudiantes guardados en: " + ruta);
    }

    public static void GuardarPuntos(List<Punto2D> puntos, string nombreArchivo = "Puntos.json")
    {
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        string json = JsonUtility.ToJson(new ListaPuntos(puntos), true);
        File.WriteAllText(ruta, json);
        Debug.Log("Puntos guardados en: " + ruta);
    }

    public static List<Estudiante> CargarEstudiantes(string nombreArchivo = "Estudiantes.json")
    {
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        if (!File.Exists(ruta)) return new List<Estudiante>();
        string json = File.ReadAllText(ruta);
        var wrapper = JsonUtility.FromJson<ListaEstudiantes>(json);
        return wrapper?.estudiantes ?? new List<Estudiante>();
    }

    public static List<Punto2D> CargarPuntos(string nombreArchivo = "Puntos.json")
    {
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        if (!File.Exists(ruta)) return new List<Punto2D>();
        string json = File.ReadAllText(ruta);
        var wrapper = JsonUtility.FromJson<ListaPuntos>(json);
        return wrapper?.puntos ?? new List<Punto2D>();
    }
}



