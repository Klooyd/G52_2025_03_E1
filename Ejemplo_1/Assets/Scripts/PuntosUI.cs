using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using packagePuntos; 

public class PuntosUI : MonoBehaviour
{
    [Header("Inputs")]
    public TMP_InputField inputX;
    public TMP_InputField inputY;

    [Header("Acciones")]
    public Button btnAgregar;
    public Button btnGuardar;

    private List<Punto2D> buffer = new();

    private void Awake()
    {
        btnAgregar.onClick.AddListener(Agregar);
        btnGuardar.onClick.AddListener(Guardar);
    }

    void Agregar()
    {
        if (!double.TryParse(inputX.text, out var x) || !double.TryParse(inputY.text, out var y))
        {
            Debug.LogWarning("X o Y inválidos");
            return;
        }

        buffer.Add(new Punto2D(x, y));
        Debug.Log($"Agregado punto ({x},{y})");
    }

    void Guardar()
    {
        if (buffer.Count == 0)
        {
            Debug.LogWarning("No hay puntos para guardar");
            return;
        }

        Utilidades.GuardarPuntos(buffer);
        Debug.Log($"Guardados {buffer.Count} puntos");
    }
}


