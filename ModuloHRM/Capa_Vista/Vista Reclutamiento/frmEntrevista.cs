﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Controlador.Controlador_Reclutamiento;


namespace Capa_Vista.Vista_Reclutamiento
{
    public partial class frmEntrevista : Form
    {

        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();

        public frmEntrevista()
        {
            InitializeComponent();
            funcLlenarTipoEntrevista();
        }

        //Declaración de variables Entidad Reclutamiento
        string IdEmpleado, IdRecluta,Comentarios;
        int Resultado,TipoEntrevista;

        

      
        //Se agrega el codigo a la variable resultado de reprobado
        private void rbtnReprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReprobado.Checked == true)
            {
                Resultado = 2;
            }
        }
        //Se agrega el codigo a la variable resultado de aprobado
        private void rbtnAprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAprobado.Checked == true)
            {
                Resultado = 1;
            }
        }

        //funcion para llenar el combo
        public void funcLlenarTipoEntrevista()
        {
            DataTable Datos = Cont_R.funcItemsEntrevista();
            cmbTipoEntrevista.DataSource = Datos;
            cmbTipoEntrevista.DisplayMember = "NOMBRE_TIPO_ENTREVISTA";
            cmbTipoEntrevista.ResetText();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                IdRecluta = txtIdBancoTalento.Text;
                gbxDatosEntrevista.Enabled = true;

                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarRecluta(txtIdBancoTalento.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        //Tabla reclutamiento

                        txtPrimerNombre.Text = Lector.GetString(1);
                        txtSegundoNombre.Text = Lector.GetString(2);
                        txtPrimerApellido.Text = Lector.GetString(3);
                        txtSegundoApellido.Text = Lector.GetString(4);
                        cmbPuestoTrabajo.Text = Lector.GetString(13);
                        cmbDepartamentoTrabajo.Text = Lector.GetString(14);
                       

                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El Id de ese Recluta no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();


                }

            }//fin ifelse
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void frmEntrevista_Load(object sender, EventArgs e)
        {
            txtIdEmpleado.MaxLength = 8;
            txtIdBancoTalento.MaxLength = 8;
        }

        private void btnIngresoEntrevista_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //Mensaje de validación de radiobuttons
                if (rbtnAprobado.Checked == false && rbtnReprobado.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado un Tipo de Resultado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    //segunda verificación de datos de cajas de texto vacias
                    if (rtxtComentarios.Text == "") { MessageBox.Show("ADVERTENCIA: No ha ingresado sus Comentarios sobre el Recluta Entrevistado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    else
                    {

                        //Mensaje de Pregunta
                        if (MessageBox.Show("¿Desea agregar un nuevo Resultado de Entrevista ?", "Entrevista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                        else
                        {

                            //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                            //datos Reclutamiento
                            IdEmpleado = txtIdEmpleado.Text;
                            TipoEntrevista = cmbTipoEntrevista.SelectedIndex + 1;
                            Comentarios = rtxtComentarios.Text;
                            //envío de datos hacia capa Controlador

                            Cont_R.funcInsertarEntrevista(IdEmpleado, IdRecluta, TipoEntrevista, Resultado, Comentarios);
                            funcLimpieza();
                            funcBloqueo();

                        }//fin elseif Pregunta

                    }//fin elseif txt

                }//fin elseif rbtn
            }

        }


        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdBancoTalento.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            cmbPuestoTrabajo.Text = "";
            cmbTipoEntrevista.Text = "";
            txtIdEmpleado.Text = "";
            rbtnAprobado.Checked = false;
            rbtnReprobado.Checked = false;
            rtxtComentarios.Text = "";



        }
        //Función de Bloqueo
        private void funcBloqueo()
        {
            gbxDatosEntrevista.Enabled = true;
        }


    }
}
