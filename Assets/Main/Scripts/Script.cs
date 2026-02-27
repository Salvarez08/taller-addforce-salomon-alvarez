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
    [SerializeField] private int _edad = 17;
    [SerializeField] private int _añoactual = 2026;

}
