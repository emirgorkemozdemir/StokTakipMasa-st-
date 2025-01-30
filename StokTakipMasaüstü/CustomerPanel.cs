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
    public partial class CustomerPanel : Form
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }

        public void MusterileriYukle()
        {
            // En başta baglantıyı kontrol etmem lazım
            SqlConnectionClass.CheckConnection();

            // CategoryPanel yüklendiginde buradaki işlemler gerçekleşecek. 
            // SqlCommand içerisine baglantımızı attık
            SqlCommand command_load = new SqlCommand("SELECT * FROM TableCustomer", SqlConnectionClass.myconnection);

            // SQL Komutunu çalıştırıp verileri ekrana almam lazım. Adapter verileri dönüştürür.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command_load);

            // Boş bir tablo görüntüsü açıyorum 
            DataTable data_table = new DataTable();

            // DataAdapter ile datatable'ı dolduruyorum
            dataAdapter.Fill(data_table);

            // datagrid'e verileri yansıttım.
            dgrid.DataSource = data_table;
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            MusterileriYukle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Buraya diger taraftan da yardım alarak müşteri ekle kodunu yazın.
            // En başta baglantıyı kontrol etmem lazım
            SqlConnectionClass.CheckConnection();

            // SqlCommand içerisine ekleme kodumuzu yazıp baglantımızı atıyoruz
            SqlCommand command_add = new SqlCommand("INSERT INTO TableCustomer (CustomerNameSurname) VALUES (@pname)", SqlConnectionClass.myconnection);

            // Açtıgım parametreye deger veriyorum
            command_add.Parameters.AddWithValue("@pname", tboxAddName.Text);

            // Komutu çalıştırıyorum
            command_add.ExecuteNonQuery();

            // Ekrandaki verileri tekrar yüklüyorum
            MusterileriYukle();
        }

        private void dgrid_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
