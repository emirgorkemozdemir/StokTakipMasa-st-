using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipMasaüstü
{
    public partial class CategoryPanel : Form
    {
        public CategoryPanel()
        {
            InitializeComponent();
        }

        private void CategoryPanel_Load(object sender, EventArgs e)
        {
            // En başta baglantıyı kontrol etmem lazım
            SqlConnectionClass.CheckConnection();

            // CategoryPanel yüklendiginde buradaki işlemler gerçekleşecek. 
            // SqlCommand içerisine baglantımızı attık
            SqlCommand command_load = new SqlCommand("SELECT * FROM TableCategory",SqlConnectionClass.myconnection);

            // SQL Komutunu çalıştırıp verileri ekrana almam lazım.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command_load);

            // Boş bir tablo görüntüsü açıyorum 
            DataTable data_table = new DataTable();

            // DataAdapter ile datatable'ı dolduruyorum
            dataAdapter.Fill(data_table);

            // datagrid'e verileri yansıttım.
            dgrid.DataSource = data_table;
        }
    }
}
