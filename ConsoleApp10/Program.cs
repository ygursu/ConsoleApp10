public partial class Form1 : Form

{

    Form2 frm2 = new Form2(); 

    public Form1()

    {

        InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)

    {

        textBox2.Visible = false;

        textBox2.Enabled = false;

    }

    private void button1_Click(object sender, EventArgs e)

    {

        if ((textBox1.Text.Length > 10) & amp; amp; amp; amp; amp; amp; &amp; amp; amp; amp; amp; amp; (textBox1.Text.Length < 12))
 
{

            frm2.Show();

            this.Hide();

            frm2.label12.Text = textBox1.Text.ToString() + ("    T.C Kimlik Numarası ile Giriş Yaptınız"); 

        }


else

            MessageBox.Show("T.C Kimlik No Boş veya 11 Haneden Küçük yada Büyük Olamaz");
    }

    private void button2_Click(object sender, EventArgs e)

    {

        Close();

    }

    private void button3_Click(object sender, EventArgs e)

    {

        textBox2.Visible = true;
    }

}



public partial class Form2 : Form

{

    Form3 frm3 = new Form3();

    int fyt, pesinat, toplam, taksit, adet, tutar, i, a, stok;

    public Form2()

    {

        InitializeComponent();

    }

    private void Form2_Load(object sender, EventArgs e)

    {

        label1.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        button2.Enabled = false;
        a = 10;

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

    {

        if (comboBox1.Text == "Bilgisayar")

        {

            comboBox2.Items.Clear();

            comboBox2.Items.Add("Vestel");
            comboBox2.Items.Add("Acer");
            comboBox2.Items.Add("Exper");
        }

        if (comboBox1.Text == "Cep Telefonu")

        {

            comboBox2.Items.Clear();

            comboBox2.Items.Add("Nokia");

            comboBox2.Items.Add("Samsung");

            comboBox2.Items.Add("LG");

        }

        if (comboBox1.Text == "Kamera")

        {

            comboBox2.Items.Clear();

            comboBox2.Items.Add("JVJ");

            comboBox2.Items.Add("Sony");

            comboBox2.Items.Add("Panasonic");

        }

    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)

    {

        if (comboBox2.Text == "Vestel")

            textBox2.Text = "1250 ";

        label15.Text = "10";

        if (comboBox2.Text == "Acer")

            textBox2.Text = "1550 ";

        label15.Text = "10";

        if (comboBox2.Text == "Exper")
            
            textBox2.Text = "1445 ";

        label15.Text = "10";

        if (comboBox2.Text == "Nokia")

            textBox2.Text = "750 ";

        label15.Text = "10";
        if (comboBox2.Text == "Samsung")
            textBox2.Text = "600 ";

        label15.Text = "10";

        if (comboBox2.Text == "LG")

            textBox2.Text = "500 ";
        label15.Text = "10";

        if (comboBox2.Text == "JVJ")

            textBox2.Text = "1000 ";

        label15.Text = "10";

        if (comboBox2.Text == "Sony")

            textBox2.Text = "1200 ";

        label15.Text = "10";

        if (comboBox2.Text == "Panasonic")
                        textBox2.Text = "1110 ";

        label15.Text = "10";

    }

    private void button1_Click(object sender, EventArgs e)

    {

        try

        {

            fyt = int.Parse(textBox2.Text);

            pesinat = int.Parse(textBox3.Text);

            adet = int.Parse(textBox4.Text);

            taksit = int.Parse(comboBox3.Text);

            if (taksit > 0)

            {

                toplam = (fyt + (fyt * adet - pesinat) * taksit * 2 / 100);

                textBox6.Text = toplam.ToString("C");

                tutar = ((toplam - pesinat) / taksit);

                textBox5.Text = tutar.ToString("C");

            }

            else if (taksit == 0)

            {

                toplam = (fyt + (fyt * adet - pesinat) * 2 / 100);

                textBox6.Text = toplam.ToString("C");

                tutar = ((toplam - pesinat));

                textBox5.Text = tutar.ToString("C");
            }

        }

        catch

        {

            MessageBox.Show(" Alanlara Sayısal Veriler Girilebilir veya Alanlar Boş Bırakılamaz");

        }

    }

    private void button4_Click(object sender, EventArgs e)

    {

        Close();
    }

    private void button3_Click(object sender, EventArgs e)

    {

        if (comboBox1.Text == "")
            MessageBox.Show("Lütfen Bir Ürün Seçiniz");

        else if (comboBox2.Text == "")

            MessageBox.Show("Lütfen Bir Ürün Adı Seçiniz");

        else if (textBox4.Text == "")

            MessageBox.Show("Lütfen Alacağınız Ürün Adedini Yazınız");

        else if (textBox5.Text == "" & amp; amp; amp; amp; amp; amp; &amp; amp; amp; amp; amp; amp; textBox6.Text == "")
 
MessageBox.Show("Lütfen  Hesapla Butonuna Basarak Aldığınız Ürünlerin Fiyatını Hesaplayınız");
else

            i++;

        label11.Text = i.ToString();

        button2.Enabled = true;


        textBox3.Text = "";

        textBox4.Text = "";

        textBox5.Text = "";

        textBox6.Text = "";

    }

    private void button2_Click(object sender, EventArgs e)

    {

        if (label15.Text == "0")

        {

            MessageBox.Show("Bu Ürün Stoklarda Bulunmamaktadır..Lütfen Başka Bir Ürün Seçiniz");

            this.Close();

        }

        else

            stok = a - int.Parse(label11.Text);

        label15.Text = stok.ToString(); 

        button2.Enabled = false;

    }

    private void button5_Click(object sender, EventArgs e)

    {

        frm3.Show();

    }

}
