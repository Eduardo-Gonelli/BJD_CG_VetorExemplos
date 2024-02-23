using UnityEngine;

public class AdicaoVetores : MonoBehaviour
{
    public Transform origemA;
    public Transform destinoA;
    public Transform origemB;
    public Transform destinoB;
    void Start()
    {
        AdicaoVetoresExemplo();
    }

    public void AdicaoVetoresExemplo() 
    { 
        Vector3 vetorA = destinoA.position - origemA.position;
        Vector3 vetorB = destinoB.position - origemB.position;
        // soma convencional dos vetores
        Vector3 vetorC = vetorA + vetorB;
        Debug.Log("A soma dos vetores utilizando A + B é: " + vetorC);
        // pode ser obtida com destinoB - origemA
        Vector3 vetorResultante = destinoB.position - origemA.position;
        Debug.Log("O vetor resultante é: " + vetorResultante);
        // instancia uma esfera vermelha com na posição do vetorC
        GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esfera.transform.localScale = Vector3.one * 0.7f;
        esfera.transform.position = vetorC;
        esfera.GetComponent<Renderer>().material.color = Color.red;
    }
}
