using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aceitera.Clases;
using i3nRiqJSON;
using System.Collections;

namespace Aceitera.Forms.Areas.Comercial
{
    public partial class frm_vehiculos : Form
    {
        int X = 0;
        int Y = 0;

        i3nRiqJson db = new i3nRiqJson();

        int EMAR = 0; int ELIN = 0; int EMOD = 0;
        int EMOT = 0; int ECIL = 0;
        public frm_vehiculos()
        {
            X = Propp.X;
            Y = Propp.Y;
            
            InitializeComponent();
            cargardatos();
        }
        

        private void frm_vehiculo_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);

        }

        private void btn_marca_Click(object sender, EventArgs e)
        {

            EdicionGlobal(1);
        }


        public void EdicionGlobal(int btn)
        {
           switch (btn)
            {
                      case 1:
                          if (EMAR == 0)
                          {
                              EdicionIndividual(btn);
                              EMAR = 1;
                          }
                          else
                          {
                              //VERIFICAR
                              //CREAR
                              cmb_marca.Visible = true;
                              txt_edit.Visible = false;
                              EMAR = 0;
                          }
                          break;
                         
                      case 2:
                          if (ELIN == 0)
                          {
                              EdicionIndividual(btn);
                              ELIN = 1;
                          }
                          else
                          {
                              //VERIFICAR
                              //CREAR
                              cmb_linea.Visible = true;
                              txt_edit.Visible = false;
                              ELIN = 0;
                          }

                          break;
                      case 3:
                          if (EMOD == 0)
                          {
                              EdicionIndividual(btn);
                              EMOD = 1;
                          }
                          else
                          {
                              //VERIFICAR
                              //CREAR
                              cmb_modelo.Visible = true;
                              txt_edit.Visible = false;
                              EMOD = 0;
                          }


                          break;
                      case 4:
                          if (EMOT == 0)
                          {
                              EdicionIndividual(btn);
                              EMOT = 1;
                          }
                          else
                          {
                              //VERIFICAR
                              //CREAR
                              cmb_motor.Visible = true;
                              txt_edit.Visible = false;
                              EMOT = 0;
                          }

                          break;
                      case 5:
                          if (ECIL == 0)
                          {
                              EdicionIndividual(btn);
                              ECIL = 1;
                          }
                          else
                          {
                              //VERIFICAR
                              //CREAR
                              cmb_cilindraje.Visible = true;
                              txt_edit.Visible = false;
                              ECIL = 0;
                          }
                          break;



                  }
        }

        public void EdicionIndividual(int btn)
        {
            switch (btn) { 
                case 1:
                    //cmb_marca.Visible = false;
                    txt_edit.Visible = true;
                    txt_edit.Location = cmb_marca.Location;
                    break;
                case 2:
                    // cmb_linea.Visible = false;
                    txt_edit.Visible = true;
                    txt_edit.Location = cmb_linea.Location;
                    break;
                case 3:
                    txt_edit.Visible = true;
                    txt_edit.Location = cmb_modelo.Location;
                    break;
                case 4:
                    txt_edit.Visible = true;
                    txt_edit.Location = cmb_motor.Location;
                    break;
                case 5:
                    txt_edit.Visible = true;
                    txt_edit.Location = cmb_cilindraje.Location;
                    break;
                
            
            
            }


            txt_edit.Focus();
        }

        public void cargardatos()
        {
            string query = "select tx_marcavehiculo,id_marcavehiculo from tbm_marcavehiculo";
            cmb_marca.DataSource = (db.consulta_ComboBox(query));

            cmb_marca.DisplayMember = "tx_marcavehiculo";
            cmb_marca.ValueMember = "id_marcavehiculo";
            //
            string query2 = "select id_modelo,tx_modelo from tbm_modelo";
            cmb_modelo.DataSource = (db.consulta_ComboBox(query2));

            cmb_modelo.DisplayMember = "tx_modelo";
            cmb_modelo.ValueMember = "id_modelo";

            string query3 = "select id_motorvehiculo,tx_motorvehiculo from  tbm_motorvehiculo";
            cmb_motor.DataSource = (db.consulta_ComboBox(query3));

            cmb_motor.DisplayMember = "tx_motorvehiculo";
            cmb_motor.ValueMember = "id_motorvehiculo";

            string query4 = "select id_cilindraje,tx_cilindraje from  tbm_cilindraje";
            cmb_cilindraje.DataSource = (db.consulta_ComboBox(query4));

            cmb_cilindraje.DisplayMember = "tx_cilindraje";
            cmb_cilindraje.ValueMember = "id_cilindraje";



        }

        private void cmb_linea_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void cmb_marca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "select id_lineavehiculo,tx_lineavehiculo from  tbm_lineavehiculo where id_marcaproducto='" + cmb_marca.SelectedValue.ToString() + "'";
            cmb_linea.DataSource = (db.consulta_ComboBox(query));

            cmb_linea.DisplayMember = "tx_lineavehiculo";
            cmb_linea.ValueMember = "id_lineavehiculo";

        }

        private void btn_linea_Click(object sender, EventArgs e)
        {
            EdicionGlobal(2);
        }

        private void btn_modelo_Click(object sender, EventArgs e)
        {
            EdicionGlobal(3);
        }

        private void btn_motor_Click(object sender, EventArgs e)
        {
            EdicionGlobal(4);
        }

        private void btn_cilindraje_Click(object sender, EventArgs e)
        {
            EdicionGlobal(5);
        }
   //

        }

        


        
    }


