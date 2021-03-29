using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Personel_kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meslekler = {"mühendis", "Öğretmen", "Öğrenci", "İşçi",
                                    "Programcı", "Muhasabeci", "Satış Pazarlama",
                                        "Ekonomist", "Müfettiş", "Avukat" };
            // bu meslekler comboBox (açılır liste kutusu) kontrolüne ekleniyor
            comboBox_meslek.Items.AddRange(meslekler);

            string[] birim = {"Satış", "Eğitim", "Pazarlama", "Reklam", "Üretim", "Muhasebe",
                                "Teknik Destek", "Yazılım", "Network", "Yönetim", "Çağrı Merkezi"};

            //bu birimler comboBox (açılır liste kutusu) kontrolüne ekleniyor
            comboBox_Calislian_birim.Items.AddRange(birim);


            //kaydedilmiş dosyayı aç
            try
            {
                //dosyayı aç
                System.IO.TextReader dosya_ac = System.IO.File.OpenText("C:\\personel_kayit.dat");
                string satir = "";

                //dosyadaki bilgileri listBox kontrollerine ekle
                while ((satir = dosya_ac.ReadLine()) != null)
                {
                    listBox1.Items.Add(satir);

                    satir = dosya_ac.ReadLine();
                    listBox2.Items.Add(satir);

                    satir = dosya_ac.ReadLine();
                    listBox3.Items.Add(satir);
                }
                //dosyayı kapat
                dosya_ac.Close();
            }
            catch
            {
                /*program ilk çalıştırıldığında önceden kaydedilmiş dosya olmayacağı için 
                 try bloğu kırılarak catch bloğu devreye girecek ancak burada herhangi
                bir işlem yapılmayacak*/
            }

            label6.Text = listBox1.Items.Count.ToString();
            label8.Text = (listBox1.SelectedIndex + 1).ToString();

        }


        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            //program kapatılırken (form kapatılırken) listBox kontrollerindeki
            //bilgiler dosyaya kaydediliyor

            //dosya oluştur
            System.IO.TextWriter dosya_kaydet = System.IO.File.CreateText("C:\\personel_kayit.dat");
            //listelerdeki verileri dosyaya aktar

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dosya_kaydet.WriteLine(listBox1.Items[i]);
                dosya_kaydet.WriteLine(listBox2.Items[i]);
                dosya_kaydet.WriteLine(listBox3.Items[i]);
            }

            //dosyayı kapat
            dosya_kaydet.Close();


        }


        //aşağıda 3 tane listBox kontrolünün SelectedIndexChanged özelliği için
        //ortak olay yaratıldı. bu olayın ismi listbox_secim dir

        private void listbox_secim(object sender, EventArgs e)
        {
            int indis;
            indis = (sender as ListBox).SelectedIndex;

            //diğer listelerde de aynı elemana ait bilgiler seçiliyor
            listBox1.SelectedIndex = indis;
            listBox2.SelectedIndex = indis;
            listBox3.SelectedIndex = indis;

            //listbox kontrolleri çok uzunsa kaydırma çubukları meydana gelecek
            //bu durumda listelerde aynı hiza olmayabilir
            //bu durumda seçili olan ifadeye karşılık gelen diğer listBox kontrolleride
            //aynı hizaya getirilir. Bunun için TopIndex değerine göre işlem yapılır

            int top_indis;
            top_indis = (sender as ListBox).TopIndex;
            listBox1.TopIndex = top_indis;
            listBox2.TopIndex = top_indis;
            listBox3.TopIndex = top_indis;

            //listelerde seçili olan satırlardaki bilgilerin 
            //textbox ve combobox kontrollerine
            //gösterimi yapılıyor.
            Txt_ad_soyad.Text = listBox1.Text;
            comboBox_meslek.Text= listBox2.Text;
            comboBox_Calislian_birim.Text = listBox3.Text;

            //seçili elemanın numarasını göster
            label8.Text = (listBox1.SelectedIndex + 1).ToString();


        }

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            //listbox kontrollerine ekleme yapılıyor
            //girilen bilgi listelerde yoksa kaydediliyor
            int yer;
            yer = listBox1.FindStringExact(Txt_ad_soyad.Text);
            if (yer < 0) // listede yoksa
            {
                listBox1.Items.Add(Txt_ad_soyad.Text);
                listBox2.Items.Add(comboBox_meslek.Text);
                listBox3.Items.Add(comboBox_Calislian_birim.Text);

                label6.Text = listBox1.Items.Count.ToString();

            }
            else //listede varsa
            {
                listBox1.SelectedIndex = yer; // bulunan kayıt
                MessageBox.Show("Bu eleman listede var");
            }


        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            //seçili olan eleman siliniyor
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Önce silinecek elemanı seçiniz");
                return;
            }

            int indis;
            DialogResult c;
            indis = listBox1.SelectedIndex;
            c = MessageBox.Show(listBox1.SelectedItem + " silinsin mi?", "Silme",
                                    MessageBoxButtons.YesNo);

            if (c == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(indis);
                listBox2.Items.RemoveAt(indis);
                listBox3.Items.RemoveAt(indis);

                label6.Text = listBox1.Items.Count.ToString();
            }
        }

        //Bul işlemi yapılıyor. Ancak aramanın sürekli olarak en son kalınan
        //yerden devam edebilmesi için aranan kelimenin bulunduğu yer bilgisi
        //tutulmalıdır. Bu sebeple yer bilgisi global olarak tanımlanıyot

        int yer = 1;
        string aranan;
        private void Btn_bul_Click(object sender, EventArgs e)
        {
            //Bul işlemi yapılıyor
            aranan = Txt_aranan.Text;
            yer = listBox1.FindStringExact(aranan);

            if (yer < 0)
            {
                //Bul işlemi yapılıyor
                yer = listBox1.FindString(aranan);
                if (yer < 0)
                {
                    MessageBox.Show("'" + aranan.ToString() + "'" + " ifadesi bulunamadı");

                }
            }

            if (yer >= 0)
            {
                listBox1.SelectedIndex = yer;
            }

        }

        private void Btn_sonrakini_Click(object sender, EventArgs e)
        {
            //sonrakini bulma işlemi
            if (yer < listBox1.Items.Count - 1)
            {
                yer = listBox1.FindString(aranan, yer);

                if (yer >= 0)
                {
                    listBox1.SelectedIndex = yer;
                }
            }
        }

        private void Btn_degistir_Click(object sender, EventArgs e)
        {
            //Değiştirme işlemi yapılıyor
            int indis;
            string adsoyad, meslek, birim;

            adsoyad = Txt_ad_soyad.Text;
            meslek = comboBox_meslek.Text;
            birim = comboBox_Calislian_birim.Text;

            indis = listBox1.SelectedIndex;

            if (indis < 0)
            {
                MessageBox.Show("önce değiştirilecek kişiyi seçiniz");
            }
            else
            {
                listBox1.Items[indis] = adsoyad;
                listBox2.Items[indis] = meslek;
                listBox3.Items[indis] = birim;
            }
        }

        private void Btn_araya_ekle_Click(object sender, EventArgs e)
        {
            // araya ekleme işlemi yapılıyor
            int indis;
            indis = listBox1.SelectedIndex;

            if (indis < 0)
            {
                MessageBox.Show("Önce elemanın nereye ekleneceğini seçiniz");

            }
            else
            {
                int yer;
                yer = listBox1.FindStringExact(Txt_ad_soyad.Text);//ifadeyi bul
                if (yer < 0)//listede yoksa listeye ekle
                {
                    listBox1.Items.Insert(indis, Txt_ad_soyad.Text);
                    listBox2.Items.Insert(indis, comboBox_meslek.Text);
                    listBox3.Items.Insert(indis, comboBox_Calislian_birim.Text);

                    label6.Text = listBox1.Items.Count.ToString();
                }
                else // listede varsa
                {
                    listBox1.SelectedIndex = yer;
                    MessageBox.Show("Bu eleman zaten var");
                }
            }
        }

        private void Btn_yeniKisi_Click(object sender, EventArgs e)
        {
            // bu butona tıklandığında textbox ve combobox kontrollerinin 
            //içeriği siliniyor
            Txt_ad_soyad.Text = "";
            comboBox_meslek.Text = "";
            comboBox_Calislian_birim.Text = "";
        }
    }
}
