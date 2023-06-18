using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RotateShip : MonoBehaviour
{
    public float velocidadRotacion = 2f;
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed = 0.1f;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener el ángulo de rotación
        float anguloRotacion = velocidadRotacion * Time.deltaTime;

        // Crear una rotación en torno al eje Y
        Quaternion rotacion = Quaternion.Euler(0f, anguloRotacion, 0f);

        // Aplicar la rotación al objeto
        transform.rotation *= rotacion;
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


}
