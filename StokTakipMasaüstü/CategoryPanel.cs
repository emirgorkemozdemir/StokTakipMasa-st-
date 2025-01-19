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

        public void KategorileriYukle()
        {
            // En başta baglantıyı kontrol etmem lazım
            SqlConnectionClass.CheckConnection();

            // CategoryPanel yüklendiginde buradaki işlemler gerçekleşecek. 
            // SqlCommand içerisine baglantımızı attık
            SqlCommand command_load = new SqlCommand("SELECT * FROM TableCategory", SqlConnectionClass.myconnection);

            // SQL Komutunu çalıştırıp verileri ekrana almam lazım.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command_load);

            // Boş bir tablo görüntüsü açıyorum 
            DataTable data_table = new DataTable();

            // DataAdapter ile datatable'ı dolduruyorum
            dataAdapter.Fill(data_table);

            // datagrid'e verileri yansıttım.
            dgrid.DataSource = data_table;
        }

        private void CategoryPanel_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // En başta baglantıyı kontrol etmem lazım
            SqlConnectionClass.CheckConnection();

            // SqlCommand içerisine ekleme kodumuzu yazıp baglantımızı atıyoruz
            SqlCommand command_add= new SqlCommand("INSERT INTO TableCategory (CategoryName) VALUES (@pname)", SqlConnectionClass.myconnection);

            // Açtıgım parametreye deger veriyorum
            command_add.Parameters.AddWithValue("@pname",tboxAddName.Text);

            // Komutu çalıştırıyorum
            command_add.ExecuteNonQuery();

            // Ekrandaki verileri tekrar yüklüyorum
            KategorileriYukle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // En başta baglantıyı kontrol etmem lazım
            SqlConnectionClass.CheckConnection();

            // SqlCommand içerisine silme kodumuzu yazıyourz
            SqlCommand command_delete = new SqlCommand("DELETE FROM TableCategory WHERE CategoryID=@pid", SqlConnectionClass.myconnection);

            // Komuttaki parametreye deger veriyorum
            command_delete.Parameters.AddWithValue("@pid",secili_id);

            // Komutu çalıştırıyorum
            command_delete.ExecuteNonQuery();

            // Ekrandaki verileri tekrar yüklüyorum
            KategorileriYukle();
        }

        int secili_id = 0;
        private void dgrid_SelectionChanged(object sender, EventArgs e)
        {
            secili_id = Convert.ToInt32(dgrid.CurrentRow.Cells[0].Value);
        }
    }
}
