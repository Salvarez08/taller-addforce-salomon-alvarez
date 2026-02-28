using UnityEngine;
using TMPro;

public class Script : MonoBehaviour

{
    //Declarar Variables
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Rigidbody2D _pelotica;
    [SerializeField] private float _minForce = 10f;
    [SerializeField] private float _maxForce = 50f;
    [SerializeField] private float _randomMagnitude;
    [SerializeField] private string _nombre = "Salomón";
    [SerializeField] private int _edad = 18;
    [SerializeField] private int _añoActual = 2026;
    [SerializeField] private int _añoNacimiento;


    //Start

    void Start()
    {
        _añoNacimiento = _añoActual - _edad;
        _randomMagnitude = Random.Range(_minForce, _maxForce);

        _saludo.text = "Hola, mi nombre es " + _nombre + " y nací en " + _añoNacimiento;

        _pelotica.AddForce(Vector2.right * _randomMagnitude, ForceMode2D.Impulse);
    }
}
