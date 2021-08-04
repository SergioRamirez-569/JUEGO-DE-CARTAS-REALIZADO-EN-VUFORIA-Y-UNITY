using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField usuarioTxt;
    public InputField passwordTxt;
    public InputField confirmarPasswordTxt;
    public InputField correoTxt;
    public GameObject _login;
    public GameObject _registro;



    public void Logear()
    {
        string _log = "`usuarios` WHERE `NOMBRE` LIKE'" + usuarioTxt.text + "'AND `CONTRASEÑA` LIKE '" + passwordTxt.text + "'";
        AdminSql _AdminSql = GameObject.Find("ConexionBaseDatos").GetComponent<AdminSql>();
        MySqlDataReader Resultado = _AdminSql.Select(_log);

        if (Resultado.HasRows)
        {
            Debug.Log("Login correcto");
            Resultado.Close();
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Debug.Log("Usuario o contraseña incorrecta");
            Resultado.Close();
        }
    }

    public void RegistrarNuevoUsuario()
    {
  
        if (usuarioTxt.text.Length >= 3 && usuarioTxt.text.Length <= 12)
        {
            if (passwordTxt.text == confirmarPasswordTxt.text)
            {
                string _log = "`usuarios` WHERE `NOMBRE` LIKE'" + usuarioTxt.text + "'";
                AdminSql _AdminSql = GameObject.Find("ConexionBaseDatos").GetComponent<AdminSql>();
                MySqlDataReader Resultado = _AdminSql.Select(_log);

                if (Resultado.HasRows)
                {
                    Debug.Log("el usuario ya xiste");
                    Resultado.Close();
                }
                else
                {
                    Resultado.Close();
                    _log = "`usuarios` (`ID`, `NOMBRE`, `CORREO`, `CONTRASEÑA`) VALUES (NULL, '" + usuarioTxt.text + "', '" +  correoTxt.text + "', '" + passwordTxt.text + "')";
                    Resultado = _AdminSql.Insert(_log);
                    Debug.Log("el nuevo usuario ha sido creado");
                    Resultado.Close();
                    AbrirCerrarRegistro();
                }
            }
            else
            {
                Debug.Log("La confirmacion de contraseñas es erronea");
            }
        }
        else
        {
            Debug.Log("El usuario debe tener entre 3 y 12 caracteres");
        }


    }

    public void AbrirCerrarRegistro()
    {
        if (_login.activeSelf)
        {
            _login.SetActive(false);
            _registro.SetActive(true);
        }
        else
        {
            _login.SetActive(true);
            _registro.SetActive(false);
        }
    }
}
