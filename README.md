**Taş Kağıt Makas Oyunu**

using System;
 
using System.Collections.Generic;
 
using System.ComponentModel;
 
using System.Data;//www.gorselprogramlama.com
 
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

**using System; **
- System, genel .NET sınıflarını içeren bir isim alanıdır. 

**using System.Collections.Generic; **
- Bu isim alanı, .NET koleksiyon sınıflarını içerir. 

**using System.ComponentModel; **
- NET bileşenleri ve olaylarını içerir.

**using System.Data; **
- NET veri işleme işlevlerini içerir.

**using System.Drawing; **
- Bu isim alanı, grafik çizme ve görüntü işleme işlevlerini içerir.

**using System.Linq; **
-LINQ (Language Integrated Query) sorguları ve işlevleri için destek sağlar.

**using System.Text; **
- Bu isim alanı, metin işleme ve karakter kodlamaları için .NET sınıflarını içerir.

**using System.Windows.Forms; **
- Bu isim alanı, Windows Forms uygulama geliştirmek için .NET sınıflarını içerir.

**namespace Tas_Kagit_Makas: **
- Namespace'ler, kodun belirli bir bölümünü sınıflar ve diğer kod öğeleriyle gruplamak için kullanılır.

**public partial class Form1 : Form: **
- Bu sınıf, Windows Forms uygulamalarındaki bir formu temsil eder. "partial" anahtar kelimesi, sınıfın bir kısmının başka bir dosyada da tanımlanabileceğini gösterir.

**public Form1(): **
- Form1 sınıfının bir yapıcı (constructor) yöntemini tanımlar. Bu yöntem, Form1 sınıfından bir nesne oluşturulduğunda otomatik olarak çalıştırılır.

**InitializeComponent(); **

- Bu satır, Windows Forms tasarımındaki bileşenlerin başlatılmasını sağlayan bir yöntemi çağırır.

---

Random r = new Random();
 
string Oyuncu1 = "", Oyuncu2 = "";
 
private string RasgeleArac(PictureBox pBox)
 
{
 
int rasgeleArac = r.Next(0, 3);
 
string aracAdi = "-";
 
switch (rasgeleArac)//www.gorselprogramlm.com

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
 
else if (aracAdi.Equals("Kağıt"))//www.gorselprogramlama.com
 
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







