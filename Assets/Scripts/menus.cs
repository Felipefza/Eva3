using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class menus : MonoBehaviour
{
    public GameObject CrosshairAndStamina;
    public GameObject interfaz;
    public GameObject menuComenzar;
    public GameObject menuPausa;
    public GameObject menuMuerte;
    public GameObject menuVictoria;
    public Image imagenOverlay;

    private GameObject FirstPersonController;
    private FirstPersonController script;

    private bool isMenuActivo = true;

    private bool init = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FirstPersonController = GameObject.Find("FirstPersonController");
    }

    public void Comenzar()
    {
        isMenuActivo = false;
        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.Locked;

        CrosshairAndStamina.SetActive(true);
        interfaz.SetActive(true);

        script.mouseSensitivity = 2f;

        menuComenzar.SetActive(false);
        menuPausa.SetActive(false);
        menuMuerte.SetActive(false);
        menuVictoria.SetActive(false);

        imagenOverlay.color = new Vector4(25f / 255f, 15f / 255f, 29f / 255f, 0);
    }

    public void Pausar()
    {
        if (isMenuActivo) {
            return;
        }

        Cursor.lockState = CursorLockMode.None;

        CrosshairAndStamina.SetActive(false);

        script.mouseSensitivity = 0f;

        Time.timeScale = 0;

        menuPausa.SetActive(true);

        imagenOverlay.color = new Vector4(25f / 255f, 15f / 255f, 29f / 255f, 192f / 255f);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Victoria()
    {
        if (isMenuActivo) {
            return;
        }

        Cursor.lockState = CursorLockMode.None;

        CrosshairAndStamina.SetActive(false);

        script.mouseSensitivity = 0f;

        Time.timeScale = 0;

        menuVictoria.SetActive(true);

        imagenOverlay.color = new Vector4(25f / 255f, 15f / 255f, 29f / 255f, 192f / 255f);
    }

    // Update is called once per frame
    void Update()
    {
        if (FirstPersonController != null && init) {
            script = FirstPersonController.GetComponent<FirstPersonController>();

            Cursor.lockState = CursorLockMode.None;

            CrosshairAndStamina.SetActive(false);

            init = false;

            script.mouseSensitivity = 0f;

            Time.timeScale = 0;
        }
        else {
            FirstPersonController = GameObject.Find("FirstPersonController");
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pausar();
        }
    }
}
