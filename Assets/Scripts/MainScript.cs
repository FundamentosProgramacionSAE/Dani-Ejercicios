using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainScript : MonoBehaviour
{


    public GameObject Tienda;
    public Text PokedolaresDisplay;
    private int Pokedolares = 0;

    public GameObject CampanaSprite;
    public GameObject PocionSprite;
    public GameObject CarameloSprite;
    public GameObject PiedraSprite;

    public GameObject CampanaTienda;
    public GameObject PocionTienda;
    public GameObject CarameloTienda;
    public GameObject PiedraTienda;

    public GameObject Pichu;
    public GameObject Pikachu;
    public GameObject Raichu;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void onTiendaButtonClick()
    {
        if (Tienda.gameObject.activeSelf == true)
        {
            Tienda.SetActive(false);
        }

        else
        {
            Tienda.SetActive(true);
        }
    }
    public void onCampanaBuy()
    {
        if (Pokedolares >= 1000)
        {
            Pokedolares -= 1000;
            PokedolaresDisplay.text = Pokedolares.ToString();
            CampanaTienda.SetActive(false);
            CampanaSprite.SetActive(true);
        }
    }
    public void onPocionBuy()
    {
        if (Pokedolares >= 500)
        {
            Pokedolares -= 500;
            PokedolaresDisplay.text = Pokedolares.ToString();
            PocionTienda.SetActive(false);
            PocionSprite.SetActive(true);
        }
    }
    public void onCarameloBuy()
    {

        if (Pokedolares >= 700)
        {
            Pokedolares -= 700;
            PokedolaresDisplay.text = Pokedolares.ToString();
            CarameloTienda.SetActive(false);
            CarameloSprite.SetActive(true);
        }
    }
    public void onPiedraBuy()
    {
        if (Pokedolares >= 500)
        {
            Pokedolares -= 500;
            PokedolaresDisplay.text = Pokedolares.ToString();
            PiedraTienda.SetActive(false);
            PiedraSprite.SetActive(true);
        }
    }
    public void onCampanaClick()
    {

    }
    public void onPocionClick()
    {

    }
    public void onCarameloClick()
    {

    }
    public void onPiedraClick()
    {

    }

    public void Luchar()
    {
        Pokedolares += 200;
        PokedolaresDisplay.text = Pokedolares.ToString();
    }

    public void EvolucionarPichu()
    {
        if (CampanaSprite.activeSelf == true)
        {
            Pichu.SetActive(false);
            Pikachu.SetActive(true);
            CampanaSprite.SetActive(false);
        }
        else
            if (PiedraSprite.activeSelf == true)
        {
            Pikachu.SetActive(false);
            Raichu.SetActive(true);
            PiedraSprite.SetActive(false);
        }


    }
}
    
   