using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class Script : MonoBehaviour

{
    //Declarar Variables
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Rigidbody2D _pelotica;
    [SerializeField] private float _fuerza = 10f;
    [SerializeField] private string _nombre = "Salomón";
    [SerializeField] private int _edad = 18;
    [SerializeField] private int _añoactual = 2026;
    [SerializeField] private int _añonacimiento;
   
    //Start

    void Start()
    {
        _añonacimiento = _añoactual - _edad;

        _saludo.text = "Hola, mi nombre es " + _nombre + " y nací en " + _añonacimiento;

        _pelotica.AddForce(Vector2.right * _fuerza, ForceMode2D.Impulse);
    }
}
