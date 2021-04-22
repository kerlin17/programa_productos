using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Class1
    {
        public MySqlConnection oconexion;
        public bool crearconexion()
        {
        bool Conectado = false;
        String servidor = "localhost", puerto = "3306", usuario = "root";
        String clave = "root", basedatos = "TABLA PRODUCTO";
        String candenaconexion = String.Format("datasource={0};port={1};username={2};password={3};database={4}", servidor, puerto, usuario, clave, basedatos);
        try 
        {
        oconexion= new MySqlConnection(cadenaconexion);
        oconexion.Open();
            Conectado= true;
        }
    catch (MySqlConnection Exeption)
    {
    MessageBox.Show
        throw;
    }
            return Conectado;

    }
    }
