using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed = 0.1f;
    private int index;

    private bool EnableDialogue = true;

    private bool evento1 = false;
    private bool evento2 = false;
    private bool evento3 = false;
    private bool evento4 = false;
    private bool evento5 = false;
    private bool evento6 = false;
    private bool evento7 = false;
    private bool evento8 = false;
    private bool evento9 = false;
    private bool evento10 = false;
    private bool evento11 = false;

    private bool loadArea2 = false;
    private bool loadArea3 = false;
    private bool loadArea4 = false;
    private bool loadArea5 = false;
    private bool loadArea6 = false;
    private bool loadArea7 = false;
    private bool loadArea8 = false;
    private bool loadArea9 = false;
    private bool loadArea10 = false;
    private bool loadArea11 = false;

    public GameObject areaEvent1, areaEvent2, areaEvent3;
    public GameObject areaEvent4, areaEvent5, areaEvent6;
    public GameObject areaEvent7, areaEvent8, areaEvent9;
    public GameObject areaEvent10, areaEvent11;

    public GameObject even1, even2, even3, even4, even5;          //Simulación de lavabo, regadera, vaso, television, cultivo
    public Light even6;                                           //luz
    public float intensityLight = 8.0f;



    // Start is called before the first frame update
    void Start()
    {
        //Inicia el dialogo inicial
        StartDialogue();

        //Desactiva los elementos que interactuan (assets de FLEX)
        even1.SetActive(false);
        even2.SetActive(false);
        even3.SetActive(false);
        even4.SetActive(false);
        even5.SetActive(false);

        //Desactiva los Box Colliders
        areaEvent2.SetActive(false);
        areaEvent3.SetActive(false);
        areaEvent4.SetActive(false);
        areaEvent5.SetActive(false);
        areaEvent6.SetActive(false);
        areaEvent7.SetActive(false);
        areaEvent8.SetActive(false);
        areaEvent9.SetActive(false);
        areaEvent10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (evento1)                                //Detecta entrada a area del lavabo
        {
            index = 1;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))
            {      //Presiona E en la zona de lavabo
                even1.SetActive(true);
                EnableDialogue = true;
                index = 2;
                NextLine();
                loadArea2 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }

        if (evento2)                                //Detecta entrada a area de la regadera
        {
            index = 3;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona de regadera
            {
                even2.SetActive(true);
                EnableDialogue = true;
                index = 4;
                NextLine();
                loadArea3 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }

        if (evento3)                                //Detecta entrada a area de elevador
        {
            index = 5;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona de elevador
            {
                transform.position = new Vector3(0.0399999991f, 11.1899996f, 0.0900000036f);
               
                EnableDialogue = true;
                index = 6;
                NextLine();
                loadArea4 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }

        if (evento4)                                //Detecta entrada a area de vaso
        {
            index = 7;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona del vaso
            {
                even3.SetActive(true);
                EnableDialogue = true;
                index = 8;
                NextLine();
                loadArea5 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }

        if (evento5)                                //Detecta entrada a area de televisor
        {
            index = 9;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona de la televisión
            {
                even4.SetActive(true);
                EnableDialogue = true;
                index = 10;
                NextLine();
                loadArea6 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }
        if (evento6)                                //Detecta entrada a area de elevador
        {
            index = 11;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona del elevador
            {
                transform.position = new Vector3(-0.0299999993f, 4.63000011f, -0.0560000017f);

                EnableDialogue = true;
                index = 12;
                NextLine();
                loadArea7 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }
        if (evento7)                                //Detecta entrada a area de cultivo
        {
            index = 13;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona del cultivo
            {
                even5.SetActive(true);
                EnableDialogue = true;
                index = 14;
                NextLine();
                loadArea8 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }
        if (evento8)                                //Detecta entrada a area de elevadorCrop
        {
            index = 15;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona del elevadorcrop
            {
                transform.position = new Vector3(-0.119999997f, 1.34000003f, 0f);

                EnableDialogue = true;
                index = 16;
                NextLine();
                loadArea9 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }
        if (evento9)
        {
            index = 17;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona de luz
            {
                even6.intensity = intensityLight;
                EnableDialogue = true;
                index = 18;
                NextLine();
                loadArea10 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }
        if (evento10)                                //Detecta entrada a area de elevadorWaterSystem
        {
            index = 19;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona del elevadorWaterSystem
            {
                transform.position = new Vector3(-0.180000007f, 14.4700003f, -0.119999997f);

                EnableDialogue = true;
                index = 20;
                NextLine();
                //loadArea11 = true;
                EnableDialogue = false;
            }
            EnableDialogue = false;
        }
        if (evento11)
        {
            index = 21;
            NextLine();
            if (Input.GetKeyDown(KeyCode.E))        //Presiona E en la zona de luz
            {
                SceneManager.LoadScene("Space");
            }
            EnableDialogue = false;
        }
    }
    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if (index <= lines.Length - 1 && EnableDialogue)
        {
          dialogueText.text = string.Empty;
          StartCoroutine(WriteLine());
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Evento1"))//Entra en area del lavabo
        {
            evento1 = true;
            evento2 = false;
            evento3 = false;
        }
        if (collision.CompareTag("Evento2"))//Entra en area de la regadera
        {
            evento2 = true;
            evento1 = false;
            evento3 = false;
        }
        if (collision.CompareTag("Evento3"))//Entra en area del elevador
        {
            evento3 = true;
            evento1 = false;
            evento2 = false;
        }
        if (collision.CompareTag("Evento4"))//Entra en area del vaso
        {
            evento4 = true;
            evento5 = false;
            evento6 = false;
        }
        if (collision.CompareTag("Evento5"))//Entra en area del televisión
        {
            evento4 = false;
            evento5 = true;
            evento6 = false;
        }
        if (collision.CompareTag("Evento6"))//Entra en area del elevador
        {
            evento4 = false;
            evento5 = false;
            evento6 = true;
        }
        if (collision.CompareTag("Evento7"))//Entra en area del cultivo
        {
            evento7 = true;
            evento8 = false;

        }
        if (collision.CompareTag("Evento8"))//Entra en area del elevador
        {
            evento8 = true;
            evento7 = false;
        }
        if (collision.CompareTag("Evento9"))//Entra en area del luz
        {
            evento9 = true;
        }
        if (collision.CompareTag("Evento10"))//Entra en area del elevador
        {
            evento10 = true;
        }
        if (collision.CompareTag("Evento11"))//Entra en area del elevador
        {
            evento11 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Evento1"))    //Sale area del lavabo
        {
            evento1 = false;
            even1.SetActive(false);
            EnableDialogue = true;
            StopAllCoroutines();
            dialogueText.text = string.Empty;
            if (loadArea2)
            {
                areaEvent1.SetActive(false);
                areaEvent2.SetActive(true);
            }
        }
        if (other.CompareTag("Evento2"))    //Sale area de la regadera
        {
            evento2 = false;
            even2.SetActive(false);
            EnableDialogue = true;
            StopAllCoroutines();
            dialogueText.text = string.Empty;
            if (loadArea3)
            {
                areaEvent2.SetActive(false);
                areaEvent3.SetActive(true);
            }
        }
        if (other.CompareTag("Evento3"))    //Sale area del elevadorRoom
        {
            evento3 = false;
            EnableDialogue = true;
            if (loadArea4)
            {
                areaEvent4.SetActive(true);
            }
        }
        if (other.CompareTag("Evento4"))    //Sale area del vaso
        {
            evento4 = false;
            even3.SetActive(false);
            EnableDialogue = true;
            StopAllCoroutines();
            dialogueText.text = string.Empty;
            if (loadArea5)
            {
                areaEvent4.SetActive(false);
                areaEvent5.SetActive(true);
            }
        }
        if (other.CompareTag("Evento5"))    //Sale area del television
        {
            evento5 = false;
            even4.SetActive(false);
            EnableDialogue = true;
            StopAllCoroutines();
            dialogueText.text = string.Empty;
            if (loadArea6)
            {
                areaEvent5.SetActive(false);
                areaEvent6.SetActive(true);
            }

        }
        if (other.CompareTag("Evento6"))    //Sale area del elevadorMainRoom
        {
            evento6 = false;
            EnableDialogue = true;
            if (loadArea7)
            {
                areaEvent7.SetActive(true);
            }
        }
        if (other.CompareTag("Evento7"))    //Sale area del cultivo
        {
            evento7 = false;
            even5.SetActive(false);
            EnableDialogue = true;
            StopAllCoroutines();
            dialogueText.text = string.Empty;
            if (loadArea8)
            {
                areaEvent7.SetActive(false);
                areaEvent8.SetActive(true);
            }
        }
        if (other.CompareTag("Evento8"))    //Sale area del elevadorCrop
        {
            evento8 = false;
            EnableDialogue = true;
            if (loadArea9)
            {
                areaEvent9.SetActive(true);
            }
        }
        if (other.CompareTag("Evento9"))    //Sale area del cultivo
        {
            evento9 = false;
            EnableDialogue = true;
            StopAllCoroutines();
            dialogueText.text = string.Empty;
            if (loadArea10)
            {
                areaEvent9.SetActive(false);
                areaEvent10.SetActive(true);
            }
        }
        if (other.CompareTag("Evento10"))    //Sale area del elevadorWaterSystem
        {
            evento10 = false;
            EnableDialogue = true;
            if (loadArea11)
            {
                areaEvent11.SetActive(true);
            }
        }
        if (other.CompareTag("Evento11"))    //Sale area del cultivo
        {
            evento11 = false;
            StopAllCoroutines();
            dialogueText.text = string.Empty;
        }
    }
}
