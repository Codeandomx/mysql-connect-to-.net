using BaseDeDatos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class Form1 : Form
    {
        #region Propiedades
        UserMapper _user;
        #endregion

        public Form1()
        {
            InitializeComponent();

            _user = new UserMapper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Conexion de prueba
                var list = _user.GetUsers();
                if(list != null)
                {
                    Console.WriteLine("Total registros: {0}", list.Count());
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
