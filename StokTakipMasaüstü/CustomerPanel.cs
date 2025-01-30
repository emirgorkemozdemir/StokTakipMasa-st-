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

        int secili_id = 0;
        private void dgrid_SelectionChanged(object sender, EventArgs e)
        {
            secili_id = Convert.ToInt32(dgrid.CurrentRow.Cells[0].Value);
            tboxUpdateName.Text = dgrid.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // secili_id degerini kullanarak ve diger taraftan yardım alarak
            // silme işlemini yazınız.
            SqlConnectionClass.CheckConnection();

            // SqlCommand içerisine ekleme kodumuzu yazıp baglantımızı atıyoruz
            SqlCommand command_add = new SqlCommand("DELETE FROM TableCustomer WHERE CustomerID=@pid", SqlConnectionClass.myconnection);

            // Açtıgım parametreye deger veriyorum
            command_add.Parameters.AddWithValue("@pid", secili_id);

            // Komutu çalıştırıyorum
            command_add.ExecuteNonQuery();

            // Ekrandaki verileri tekrar yüklüyorum
            MusterileriYukle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.CheckConnection();

            SqlCommand command_update = new SqlCommand("UPDATE TableCustomer SET CustomerNameSurname=@pname WHERE CustomerID=@pid",SqlConnectionClass.myconnection);
            command_update.Parameters.AddWithValue("@pname",tboxUpdateName.Text);
            command_update.Parameters.AddWithValue("@pid", secili_id);
            command_update.ExecuteNonQuery();
            MusterileriYukle();
        }
    }
}
