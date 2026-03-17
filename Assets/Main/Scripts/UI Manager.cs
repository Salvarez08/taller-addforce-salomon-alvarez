using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
   public Image _barraDeVida;
    private void Start()
    {
        _barraDeVida.fillAmount = 1; 
    }
    public void ColorBarraDeVida(Color color)
    {
       _barraDeVida.color = color;

    }
    public void FillAmountBarraDeVida(float fillAmount)
    {
     _barraDeVida.fillAmount = fillAmount;
    }
}
