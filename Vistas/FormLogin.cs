﻿using Sis_GestionActivos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Vistas
{
    public partial class FormLogin : Form
    {
        private LoginControlador loginControlador;
        public FormLogin()
        {
            InitializeComponent();            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            loginControlador = new LoginControlador();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string password = txt_pwd.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("El campo usuario se encuentre vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El campo contraseña se encuentre vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool usuarioAutenticado = loginControlador.IniciarSesion(usuario, password);

            if (usuarioAutenticado)
            {
                FormInicial formInicial = new FormInicial();
                this.Hide();

                DataTable dtDatosUsuario = new DataTable();
                dtDatosUsuario = loginControlador.DatosUsuario(usuario);

                var nombre_usuario = dtDatosUsuario.Rows[0]["nombre_usuario"].ToString() + " " + dtDatosUsuario.Rows[0]["apellidos_usuario"].ToString();
                var id_rol_usuario = dtDatosUsuario.Rows[0]["rol_usuario"].ToString();
                var nombre_rol = dtDatosUsuario.Rows[0]["nombre_rol"].ToString();

                Funciones.GetUsuarioLogin(usuario);

                formInicial.datosInicioSesion(nombre_usuario,id_rol_usuario, nombre_rol);
                formInicial.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario ingresado no se encontro. Revise las credenciales y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
    }
}
