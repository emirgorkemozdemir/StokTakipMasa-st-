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
    public partial class ProductPanel : Form
    {
        public ProductPanel()
        {
            InitializeComponent();
        }
        public void UrunleriYukle()
        {

            // En başta baglantıyı kontrol etmem lazım
            SqlConnectionClass.CheckConnection();

            // CategoryPanel yüklendiginde buradaki işlemler gerçekleşecek. 
            // SqlCommand içerisine baglantımızı attık
            SqlCommand command_load = new SqlCommand("SELECT ProductName,ProductPrice,CategoryName, ProductStock FROM TableProduct INNER JOIN TableCategory ON ProductCategoryID = CategoryID", SqlConnectionClass.myconnection);

            // SQL Komutunu çalıştırıp verileri ekrana almam lazım. Adapter verileri dönüştürür.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command_load);

            // Boş bir tablo görüntüsü açıyorum 
            DataTable data_table = new DataTable();

            // DataAdapter ile datatable'ı dolduruyorum
            dataAdapter.Fill(data_table);

            // datagrid'e verileri yansıttım.
            dataGridView1.DataSource = data_table;
        }
        private void ProductPanel_Load(object sender, EventArgs e)
        {
            UrunleriYukle();
        }
    }
}
