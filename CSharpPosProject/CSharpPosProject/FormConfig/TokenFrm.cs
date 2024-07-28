using CSharpPosProject.Datos;

using CSharpPosProject.Entidad;
using CSharpPosProject.Handler;
using CSharpPosProject.Red;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPosProject.Formularios
{
    public partial class TokenFrm : Form
    {

        string str_oauth;
        Credencial cred;
        OAUTHmhRequest oauthRequest;
        XMLCredencial xcred;
        OauthSQLite oauthSQLite;
        // OauthPostgreSQL oauthPostgreSQL;
        Oauth oauth;
        TokenHandler tokenHandler;
        //TokenHandlerPG tokenHandlerPG;
        public TokenFrm()
        {
            InitializeComponent();

            comboBox2.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cred = new Credencial();
            oauth = new Oauth();
            oauthRequest = new OAUTHmhRequest();
            oauthSQLite = new OauthSQLite();
            //oauthPostgreSQL = new OauthPostgreSQL();
            xcred = new XMLCredencial();
            tokenHandler = new TokenHandler();
            //tokenHandlerPG = new TokenHandlerPG();
            //selectedIndex = comboBox1.SelectedIndex; eliminar
            if (comboBox2.SelectedIndex == 0)
            {
                // (comboBox2.selectedIndex = 0) = nuevo
                //MessageBox.Show(comboBox1.Text);
                if (radioButton1.Checked)//httpwebrequest
                {
                    cred = xcred.LecturaUrlCode(comboBox1.Text);
                    str_oauth = oauthRequest.postHttpWebRequest(cred);

                    //PostgreSQL oauth = tokenHandlerPG.getOauthObject(str_oauth, comboBox1.SelectedText.ToString());

                    oauth = tokenHandler.getOauthObject(str_oauth, comboBox1.Text); //SQLITE
                    textBox1.Text = "token= " + oauth.Token + " refresh= " + oauth.Refresh;
                }
                if (radioButton2.Checked)//restsharp
                {
                    cred = xcred.Lectura(comboBox1.Text);
                    str_oauth = oauthRequest.postRestSharp(cred);

                    //PostgreSQL oauth = tokenHandlerPG.getOauthObject(str_oauth, comboBox1.SelectedText.ToString());

                    oauth = tokenHandler.getOauthObject(str_oauth, comboBox1.Text);//SQLITE
                    textBox1.Text = "token= " + oauth.Token + " refresh= " + oauth.Refresh;
                }
                
                // PostgreSQL oauth = tokenHandlerPG.getOauthObject(str_oauth, comboBox1.SelectedText.ToString());

                //oauth = tokenHandler.getOauthObject(str_oauth, comboBox1.SelectedText.ToString()); //SQLite

            }
            else if (comboBox2.SelectedIndex == 1)
            {
                //comboBox2 = almacenado

                //oauthPostgreSQL = new OauthPostgreSQL(); //PostgreSQL

                oauthSQLite = new OauthSQLite();//SQLITE
                oauth = new Oauth();
                oauth = oauthSQLite.selectAll(comboBox1.Text);

                //PostgresSQL oauth = oauthPostgreSQL.selectAllDecode(comboBox1.Text);
                textBox1.Text = "token =" + oauth.Token + "\n" + " refresh =" + oauth.Refresh + "stored ="
                    + oauth.Expiresstr;
                //oauth = tokenHandler.getOauthObject(str_oauth, "produccion");


            }


            //cred = xcred.Lectura(param);
            //textBox1.Text = oauth.postHttpClientSync(cred);        
            //textBox1.Text = oauth.postRestSharp(cred);

        }




    }
}
