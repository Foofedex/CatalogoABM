﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Acciones;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;

namespace Catalogo
{
    public partial class FMRArticulo : Form
    {
        public Articulo artiNuevo = new Articulo();
        public FMRArticulo()
        {
            InitializeComponent();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string validarUrl(string url)
        {
            string aux=url;

            if (aux.Length < 1000) { return aux; }
            else { return aux = "Cadena muy larga"; };
          

        }


        private bool validarCamposTxt()
        {
            bool ok = true;

            if(TXTBID.Text == "")
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(TXTBID, "Ingrese el Codigo.");
            }

            if (TXTBNombre.Text == "")
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(TXTBNombre, "Ingrese el Nombre.");
            }
            if (TXTBDescripcion.Text == "")
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(TXTBDescripcion, "Ingrese la Descripcion.");
            }
            if (cboMarca.SelectedIndex < 0)
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(cboMarca, "Seleccione la Marca.");
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(cboCategoria, "Seleccione la Categoria.");
            }
            if (TXTBPrecio.Text == "")
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(TXTBPrecio, "Ingrese el Precio.");
            }
            if (txtbUrlImagen.Text == "")
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(txtbUrlImagen, "Ingrese la Url.");
            }


            return ok;
        }

        private void EliminarIconosErrorProv()
        {
            ErrorProvCargaArticulo.SetError(TXTBID, "");
            ErrorProvCargaArticulo.SetError(TXTBNombre, "");
            ErrorProvCargaArticulo.SetError(TXTBDescripcion, "");
            ErrorProvCargaArticulo.SetError(cboMarca, "");
            ErrorProvCargaArticulo.SetError(cboCategoria, "");
            ErrorProvCargaArticulo.SetError(TXTBPrecio, "");
            ErrorProvCargaArticulo.SetError(txtbUrlImagen, "");
           
        }



            private void BTNAdd_Click_1(object sender, EventArgs e)
            {

              
              conexionART conexion = new conexionART();
              try
              {

                EliminarIconosErrorProv();
                if (validarCamposTxt())
                {
                    MessageBox.Show("Datos Ingresados Correctamente.");
                }
                validarCamposTxt();

                  artiNuevo.Codigo = TXTBID.Text;
                  artiNuevo.Nombre = TXTBNombre.Text;
                  artiNuevo.Descripcion = TXTBDescripcion.Text;
                  artiNuevo.Precio = SqlMoney.Parse(TXTBPrecio.Text);
                  string url = txtbUrlImagen.Text;
                  artiNuevo.Imagen = validarUrl(url);

                  conexion.Agregar(artiNuevo);
                  MessageBox.Show("Articulo agregado");
                  Close();
              }
              
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }


            }

        private void FMRArticulo_Load_1(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            AccesoDatos accesoDatos2 = new AccesoDatos();

            try
            {

                accesoDatos.setearQuery("select id, Descripcion From Marcas");
                accesoDatos.ejecutarLectura();


                while (accesoDatos.Lector.Read())
                {
                    cboMarca.Items.Add((string)accesoDatos.Lector["Descripcion"]);

                }

                accesoDatos2.setearQuery("select id, Descripcion From CATEGORIAS");
                accesoDatos2.ejecutarLectura();

                while (accesoDatos2.Lector.Read())
                {

                    cboCategoria.Items.Add((string)accesoDatos2.Lector["Descripcion"]);

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("fallo");
            }

            finally
            {
                accesoDatos.cerrarConexion();
                accesoDatos2.cerrarConexion();
            }
        }
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            artiNuevo.IDMarca =(cboMarca.SelectedIndex+1);
           

        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            artiNuevo.IDCategoria = (cboCategoria.SelectedIndex+1);
           
        }

        private void TXTBPrecio_Validating(object sender, CancelEventArgs e)
        {
            float numero;
            if(!float.TryParse(TXTBPrecio.Text, out numero))
            {
                ErrorProvCargaArticulo.SetError(TXTBPrecio, "Ingrese valor numerico.");
            }
            else
            {
                ErrorProvCargaArticulo.SetError(TXTBPrecio, "");
            }
        }
    }
}
