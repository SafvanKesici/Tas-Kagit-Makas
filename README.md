# Taş Kağıt Makas Oyunu

#### Önemli bir not: Anlatacağım Taş Kağıt Makas oyununa ait C# kodlarını daha etkin bir biçimde sunabilmek için bölüm bölüm alarak kodları sizlerle paylaştım ve ardından sırasıyla işlevleri hakkında bilgi vermek istedim. 

using System;
 
using System.Collections.Generic;
 
using System.ComponentModel;
 
using System.Data;
 
using System.Drawing;
 
using System.Linq;
 
using System.Text;
 
using System.Windows.Forms;
 
namespace Tas___Kagit___Makas
 
{
 
public partial class Form1 : Form
 
{
 
public Form1()
 
{
 
InitializeComponent();
 
}

---

**using System,**
- System, genel .NET sınıflarını içeren bir isim alanıdır. 

**using System.Collections.Generic;**
- Bu isim alanı, .NET koleksiyon sınıflarını içerir. 

**using System.ComponentModel;**
- NET bileşenleri ve olaylarını içerir.

**using System.Data;**
- NET veri işleme işlevlerini içerir.

**using System.Drawing;**
- Bu isim alanı, grafik çizme ve görüntü işleme işlevlerini içerir.

**using System.Linq;**
-LINQ (Language Integrated Query) sorguları ve işlevleri için destek sağlar.

**using System.Text;**
- Bu isim alanı, metin işleme ve karakter kodlamaları için .NET sınıflarını içerir.

**using System.Windows.Forms;**
- Bu isim alanı, Windows Forms uygulama geliştirmek için .NET sınıflarını içerir.

**namespace Tas_Kagit_Makas:**
- Namespace'ler, kodun belirli bir bölümünü sınıflar ve diğer kod öğeleriyle gruplamak için kullanılır.

**public partial class Form1 : Form:**
- Bu sınıf, Windows Forms uygulamalarındaki bir formu temsil eder. "partial" anahtar kelimesi, sınıfın bir kısmının başka bir dosyada da tanımlanabileceğini gösterir.

**public Form1():**
- Form1 sınıfının bir yapıcı (constructor) yöntemini tanımlar. Bu yöntem, Form1 sınıfından bir nesne oluşturulduğunda otomatik olarak çalıştırılır.

**InitializeComponent();**

- Bu satır, Windows Forms tasarımındaki bileşenlerin başlatılmasını sağlayan bir yöntemi çağırır.

---

Random r = new Random();
 
string Oyuncu1 = "", Oyuncu2 = "";
 
private string RasgeleArac(PictureBox pBox)
 
{
 
int rasgeleArac = r.Next(0, 3);
 
string aracAdi = "-";
 
switch (rasgeleArac)

---

**Random r = new Random();** 

- Random sınıfından bir r isimli yeni bir örnek oluşturur. Rastgele sayılar oluşturmak için kullanılır.

**string Oyuncu1 = "", Oyuncu2 = "";**

- İki adet boş dize değişkeni olan Oyuncu1 ve Oyuncu2 tanımlanır ve boş olarak başlatılır. Bu değişkenler, iki oyuncunun isimlerini temsil ediyor gibi görünmektedir.

**private string RasgeleArac(PictureBox pBox):**

- PictureBox türünde pBox parametresi alan ve bir dize değeri döndüren RasgeleArac isimli özel bir metodu tanımlar. Bu metot, rastgele bir araç ismi oluşturmak için kullanılır.

**int rasgeleArac = r.Next(0, 3);**

- Random sınıfının Next metodunu kullanarak 0 (dahil) ile 3 (hariç) arasında bir rastgele tamsayı oluşturur ve bu değeri rasgeleArac değişkenine atar.

**string aracAdi = "-";**

- aracAdi isimli bir dize değişkeni tanımlar ve onu bir tire ("-") ile başlatır.

**switch (rasgeleArac):**

- switch ifadesi, rasgeleArac değerini değerlendirir ve değerine bağlı olarak hangi case'in çalıştırılacağını belirler.

---

case 0: aracAdi = "Taş"; break;
 
case 1: aracAdi = "Kağıt"; break;
 
case 2: aracAdi = "Makas"; break;
 
}
 
if (aracAdi.Equals("Taş"))
 
{
 
pBox.Image = Properties.Resources.tas;
 
}
 
else if (aracAdi.Equals("Kağıt"))
 
{
 
pBox.Image = Properties.Resources.kagit;
 
}
 
else // Makas
 
{
 
pBox.Image = Properties.Resources.makas;
 
}
 
return aracAdi;

---

- Bu kod satırında, aracAdi değişkenine atanmış olan taş, kağıt veya makas değerine göre bir görüntüyü pBox  PictureBox'a atamak için kullanılıyor. Ayrıca, aracAdi değerini geri döndürüyor.

**case 0: aracAdi = "Taş"; break;**

- Eğer rasgeleArac değeri 0 ise, aracAdi değişkenine "Taş" atanır.

**case 1: aracAdi = "Kağıt"; break;**

- Eğer rasgeleArac değeri 1 ise, aracAdi değişkenine "Kağıt" atanır.

**case 2: aracAdi = "Makas"; break;**
- Eğer rasgeleArac değeri 2 ise, aracAdi değişkenine "Makas" atanır.

- Sonrasında, if-else ifadeleri kullanılarak aracAdi değişkeninin değeri kontrol edilir ve pBox PictureBox'ına ilgili görüntü atanır.

**if (aracAdi.Equals("Taş"))**

- Eğer aracAdi değeri "Taş" ise:
pBox.Image özelliği Properties.Resources.tas kaynağına atanır. Bu, "tas" isimli bir kaynak dosyasının Resources klasörü altında bulunması gerektiğini varsayar.

**else if (aracAdi.Equals("Kağıt")):**

-  Eğer aracAdi değeri "Kağıt" ise:
pBox.Image özelliği Properties.Resources.kagit kaynağına atanır. Bu, "kagit" isimli bir kaynak dosyasının Resources klasörü altında bulunması gerektiğini varsayar.

**else:**

- ukarıdaki durumlar dışında (yani aracAdi değeri "Makas" ise):
pBox.Image özelliği Properties.Resources.makas kaynağına atanır. Bu, "makas" isimli bir kaynak dosyasının Resources klasörü altında bulunması gerektiğini varsayar.

**return aracAdi;**

- Son olarak, aracAdi değeri geri döndürülür.

---

private void KazanmaDurumu()
 
{
 
string Durum = "";
 
if (Oyuncu1 == "Taş" && Oyuncu2 == "Makas")
 
{
 
Durum = "Taş, Makas'ı kırar. Oyuncu 1 kazandı.";
 
}
 
else if (Oyuncu1 == "Makas" && Oyuncu2 == "Taş")
 
{
 
Durum = "Taş, Makas'ı kırar. Oyuncu 2 kazandı.";
 
}
 
else if (Oyuncu1 == "Kağıt" && Oyuncu2 == "Taş")
 
{
 
Durum = "Kağıt, Taş'ı sarar. Oyuncu 1 kazandı.";
 
}
 
else if (Oyuncu1 == "Taş" && Oyuncu2 == "Kağıt")
 
{
 
Durum = "Kağıt, Taş'ı sarar. Oyuncu 2 kazandı.";
 
}
 
else if (Oyuncu1 == "Makas" && Oyuncu2 == "Kağıt")
 
{
 
Durum = "Makas, Kağıdı keser. Oyuncu 1 kazandı.";
 
}
 
else if (Oyuncu1 == "Kağıt" && Oyuncu2 == "Makas")
 
{
 
Durum = "Makas, Kağıdı keser. Oyuncu 2 kazandı.";
 
}
 
else if (Oyuncu1 == Oyuncu2)
 
{
 
Durum = "Berabere";
 
}
 
lblDurum.Text = Durum;
 
}

- Bu kod satırında , Oyuncu1 ve Oyuncu2 değişkenlerindeki taş, kağıt veya makas seçimlerine göre kazananı belirlemek için kullanılır. Kazanan durumu Durum değişkenine atar ve lblDurum isimli bir etikete metin olarak görüntüler.

**string Durum = "";**

- Boş bir Durum metin değişkeni oluşturulur.

**if (Oyuncu1 == "Taş" && Oyuncu2 == "Makas"):**

- Eğer Oyuncu1 "Taş" seçtiyse ve Oyuncu2 "Makas" seçtiyse:Durum değişkenine "Taş, Makas'ı kırar. Oyuncu 1 kazandı." metni atanır.

**else if (Oyuncu1 == "Makas" && Oyuncu2 == "Taş")**

- Eğer Oyuncu1 "Makas" seçtiyse ve Oyuncu2 "Taş" seçtiyse:Durum değişkenine "Taş, Makas'ı kırar. Oyuncu 2 kazandı." metni atanır.

- Diğer durumlar için benzer şekilde else if ifadeleri kullanılır

**else if (Oyuncu1 == "Kağıt" && Oyuncu2 == "Taş")**

- Oyuncu1 "Kağıt" seçtiyse ve Oyuncu2 "Taş" seçtiyse:
Durum değişkenine "Kağıt, Taş'ı sarar. Oyuncu 1 kazandı." metni atanır.

**else if (Oyuncu1 == "Taş" && Oyuncu2 == "Kağıt")**

- Oyuncu1 "Taş" seçtiyse ve Oyuncu2 "Kağıt" seçtiyse:
Durum değişkenine "Kağıt, Taş'ı sarar. Oyuncu 2 kazandı." metni atanır.

**else if (Oyuncu1 == "Makas" && Oyuncu2 == "Kağıt")**

- Oyuncu1 "Makas" seçtiyse ve Oyuncu2 "Kağıt" seçtiyse:
Durum değişkenine "Makas, Kağıdı keser. Oyuncu 1 kazandı." metni atanır.

**else if (Oyuncu1 == "Kağıt" && Oyuncu2 == "Makas")**

- Oyuncu1 "Kağıt" seçtiyse ve Oyuncu2 "Makas" seçtiyse:
Durum değişkenine "Makas, Kağıdı keser. Oyuncu 2 kazandı." metni atanır.

**else if (Oyuncu1 == Oyuncu2)**

- Eğer Oyuncu1 ve Oyuncu2 aynı seçimi yaparsa:
Durum değişkenine "Berabere" metni atanır.

**lblDurum.Text = Durum;**

-  Durum metni lblDurum etiketinin metin özelliğine atanır ve kullanıcıya gösterilir.

---

private void btnOy1_Click(object sender, EventArgs e)
 
{
 
Oyuncu1 = RasgeleArac(pbOy1);
 
btnOy1.Enabled = false;
 
}
 
private void btnOy2_Click(object sender, EventArgs e)
 
{
 
if (!btnOy1.Enabled)
 
{
 
Oyuncu2 = RasgeleArac(pbOy2);
 
KazanmaDurumu();
 
btnOy2.Enabled = false;
 
}
 
else
 
{
 
MessageBox.Show("Önce birinci oyuncu oynamalıdır.","Dikkat");
 
}
 
}
 
private void btnYeniOyun_Click(object sender, EventArgs e)
 
{
 
btnOy1.Enabled = true;
 
btnOy2.Enabled = true;
 
Oyuncu1 = ""; Oyuncu2 = "";
 
lblDurum.Text = "";
 
pbOy1.Image = null; pbOy2.Image = null;

---

- Burada bir oyuncu seçeneği seçtiğinde ve diğer oyuncu da seçeneğini seçtiğinde gerçekleşecek olayları belirtir. Ayrıca, yeni bir oyun başlatıldığında da yapılması gerekenleri tanımlar

**private void btnOy1_Click(object sender, EventArgs e)**

- Oyuncu 1'in butonuna tıklandığında gerçekleşecek olay:

**Oyuncu1 = RasgeleArac(pbOy1);**

- RasgeleArac fonksiyonunu kullanarak Oyuncu 1'in araç seçimini belirler ve Oyuncu1 değişkenine atar.

**btnOy1.Enabled = false;**

- Oyuncu 1'in butonunu devre dışı bırakır.

**private void btnOy2_Click(object sender, EventArgs e)**

- Oyuncu 2'nin butonuna tıklandığında gerçekleşecek olay:

**if (!btnOy1.Enabled)**

- Eğer Oyuncu 1'in butonu etkin değilse:

**Oyuncu2 = RasgeleArac(pbOy2);**

- RasgeleArac fonksiyonunu kullanarak Oyuncu 2'nin araç seçimini belirler ve Oyuncu2 değişkenine atar.

**KazanmaDurumu();**

- Kazanan durumunu kontrol etmek için KazanmaDurumu fonksiyonunu çağırır.

**btnOy2.Enabled = false;**

- Oyuncu 2'nin butonunu devre dışı bırakır.
else: Aksi takdirde:
"Önce birinci oyuncu oynamalıdır." mesajını içeren bir ileti kutusu görüntüler.

**private void btnYeniOyun_Click(object sender, EventArgs e)**

- "Yeni Oyun" butonuna tıklandığında gerçekleşecek olay:

**btnOy1.Enabled = true;**

- Oyuncu 1'in butonunu etkinleştirir.

**btnOy2.Enabled = true;** 

- Oyuncu 2'nin butonunu etkinleştirir.

**Oyuncu1 = ""; Oyuncu2 = "";**

- Oyuncu 1 ve Oyuncu 2'nin seçimlerini sıfırlar.

**lblDurum.Text = ""; **

- Kazanan durumu görüntüleyen etiketin metnini temizler.

**pbOy1.Image = null; pbOy2.Image = null;**

- Oyuncu 1 ve Oyuncu 2'nin araç görüntülerini temizler.









