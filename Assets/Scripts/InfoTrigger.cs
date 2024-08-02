using UnityEngine;
using UnityEngine.UI;

public class InfoTrigger : MonoBehaviour
{
    public GameObject infoText;  // Bilgilendirme yaz�s� GameObject'ini burada tan�mla

    void Start()
    {
        if (infoText != null)
        {
            infoText.SetActive(false);  // Ba�lang��ta bilgilendirme yaz�s�n� gizle
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Oyuncu karakterinin tag'� "Player" olarak ayarland���n� varsay�yoruz
        {
            if (infoText != null)
            {
                infoText.SetActive(true);  // Karakter collider'a girince bilgilendirme yaz�s�n� g�ster
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (infoText != null)
            {
                infoText.SetActive(false);  // Karakter collider'dan ��k�nca bilgilendirme yaz�s�n� gizle
            }
        }
    }
}
