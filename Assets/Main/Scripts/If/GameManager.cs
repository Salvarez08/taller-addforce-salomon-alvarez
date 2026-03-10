using UnityEngine;

public class GameManager : MonoBehaviour
{
    //declarar variables
    [SerializeField] private float _vidajugador = 100;
    [SerializeField] private PlayerController playerController;

    public void SumarVida(int cura)
    {
        if (_vidajugador <= 100)
        {
            _vidajugador += cura;
            Debug.Log("sumar" + cura + "puntos de vida");
        }
        else
        {
            _vidajugador = 100;
            Debug.Log("vida al maximo");
        }
    }
    public void RestarVida(int daño)
    {
        if (_vidajugador > 0)
        {
            _vidajugador -= daño;
            Debug.Log("restar" + daño + "puntos de vida");

        }
        if (_vidajugador <= 0)
        {
            Destroy(playerController.gameObject);
        }
    }
}
