using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginAndRegistrPage : MonoBehaviour
{
    public InputField emailField;
    public InputField nameField;
    public InputField passwordField;
    public Button loginButton;
    public Button registrationButton;
    public Text errorText;

    void Start()
    {
        loginButton.onClick.AddListener(delegate {
            login();
        });

        registrationButton.onClick.AddListener(delegate {
            register();
        });
    }

    private void login() 
    {
        SceneManager.LoadScene("Menu");
    }

    public void Reset () 
    {
        emailField.text = string.Empty;
        nameField.text = string.Empty;
        passwordField.text = string.Empty;
    }

    private void register() 
    {
        
    }
}
