**Taş Kağıt Makas Oyunu**
C# Örneği:
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
using System;
System, genel .NET sınıflarını içeren bir isim alanıdır.

using System.Collections.Generic;
Bu isim alanı, .NET koleksiyon sınıflarını içerir.

using System.ComponentModel;
NET bileşenleri ve olaylarını içerir.

using System.Data;
NET veri işleme işlevlerini içerir.

using System.Drawing;
Bu isim alanı, grafik çizme ve görüntü işleme işlevlerini içerir.

using System.Linq;
LINQ (Language Integrated Query) sorguları ve işlevleri için destek sağlar.

using System.Text;
Bu isim alanı, metin işleme ve karakter kodlamaları için .NET sınıflarını içerir.

using System.Windows.Forms;
Bu isim alanı, Windows Forms uygulama geliştirmek için .NET sınıflarını içerir.

namespace Tas_Kagit_Makas:
Namespace'ler, kodun belirli bir bölümünü sınıflar ve diğer kod öğeleriyle gruplamak için kullanılır.

public partial class Form1 : Form:
Bu sınıf, Windows Forms uygulamalarındaki bir formu temsil eder. "partial" anahtar kelimesi, sınıfın bir kısmının başka bir dosyada da tanımlanabileceğini gösterir.

public Form1():
Form1 sınıfının bir yapıcı (constructor) yöntemini tanımlar. Bu yöntem, Form1 sınıfından bir nesne oluşturulduğunda otomatik olarak çalıştırılır.

InitializeComponent();:
Bu satır, Windows Forms tasarımındaki bileşenlerin başlatılmasını sağlayan bir yöntemi çağırır.



