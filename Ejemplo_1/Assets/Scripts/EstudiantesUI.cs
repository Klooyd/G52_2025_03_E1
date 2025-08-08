using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using packagePersona;

public class EstudiantesUI : MonoBehaviour
{
    [Header("Inputs")]
    public TMP_InputField codeE;
    public TMP_InputField Carrera;
    public TMP_InputField Nombre;
    public TMP_InputField Mail;
    public TMP_InputField Direccion;

    [Header("Acciones")]
    public Button btnAgregar;
    public Button btnGuardar;

    private List<Estudiante> buffer = new();

    private void Awake()
    {
        btnAgregar.onClick.AddListener(Agregar);
        btnGuardar.onClick.AddListener(Guardar);
    }

    void Agregar()
    {
        if (string.IsNullOrWhiteSpace(codeE.text) || string.IsNullOrWhiteSpace(Nombre.text))
        {
            Debug.LogWarning("Faltan datos");
            return;
        }

        var e = new Estudiante(
            codeE.text, Carrera.text, Nombre.text, Mail.text, Direccion.text
        );

        buffer.Add(e);
        Debug.Log($"Agregado estudiante: {e.nameP}");
    }

    void Guardar()
    {
        if (buffer.Count == 0)
        {
            Debug.LogWarning("No hay estudiantes para guardar");
            return;
        }

        Utilidades.GuardarEstudiantes(buffer);
        Debug.Log($"Guardados {buffer.Count} estudiantes");
    }
}


