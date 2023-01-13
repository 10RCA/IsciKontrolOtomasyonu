# IsciKontrolOtomasyonu

Projemizi Açabilmek İçin Gerekli Olan İndirmeler

* Bilgisayarınıza "SQL Server 2019 Configuration Manager" ve "Microsoft SQL Server Management Studio 18" uygulamalarının kurulumlarını yapın.
** SQL Server 2019 Configuration Manager ==> https://www.microsoft.com/en-us/download/details.aspx?id=55994
*** Microsoft SQL Server Management Studio 18 ==> https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

Kurulum 

* Öncelikle SQL bağlantımıza ihtiyacımız var. Adres.txt dosyasını kopyalayıp masaüstüne yapıştıralım. Dosyayı açtıktan sonra bağlantı için = kısmından sonraki "." yazan kısmı silip kendi SQL server adınızı kaydedin. Sonra bu dosyayı Yerel Disk C içine atın.
** Tablolar klasörünü açalım. İçerisindeki tabloları kopyalayıp C:\Program Files\Microsoft SQL Server yolunu takip edelim. Adres.txt dosyayının içine yazdığınız server adıyla eşleşen klasöre girip MSSQL ve ardından da DATA isimli klasörü açıp kopyaladığımız tabloları yapıştıralım. (!BU İŞLEM ESNASINDA "SQL SERVER 2019 Configuratin Manager" üzerinden ilgili sevver'ın çalışmasını durdurun yoksa HATA alırsınız.)
*** Yapıştırma işleminin ardından server'ı tekrar başlatın.
**** Microsoft SQL Server Management Studio 18'i açıp Adres.txt dosyasının içine yazdığımız server'a bağlanalım. Databases ismindeki klasöre sağ tık yapıp Attach seçeneğine basalım. Database to Attach seçeneğinden "Add" butonuna tıklayalım ve Personel_Takip.mdf adlı dosyayı seçip OK butonuna basın ve ardından tekrar OK butonuna basın.
***** Setup Klasöründen IsciKontrolu.msi dosyasını çalıştıralım ve kutulumu yapalım.

Kullanım Senaryoları

* Otomasyona giriş kısmından yönetici rolü ile giriş yapmak için Kullanıcı adı: admin, şifre 123 şeklinde bir giriş yapalım. Kullanıcı olarak giriş yapmak için Kullanıcı Adı: onur şifre: 123 şeklinde giriş yapabiliriz.
** Ardından açılan 3 buton bizim işlemleri seçebildiğimiz paneldir. 
*** Departmanlar panelinden şirketteki pozisyonları belirleyebiliriz. Departman ID salt okunur şeklinde gelecek ve değişiklik yapılamayacaktır. Çünkü Veritabanımızda bilgiler ID üzerinden çekilir ve saklanır. Yeni departman eklemek, var olan departmanı güncellemek ve var olan bir departmanı silmek için gerekli kombinasyonlar mevcuttur. Çıkış butonundan Ana Sayfa kısmına dönebiliriz.
**** Personel Ekle panelinden İşçi kaydımızı oluşturabiliriz. Adı Soyadı Telefonu Adresi Emaili Departmanı Maaşı ve Giriş Tarihini tutabiliriz. Çıkış butonundan Ana Sayfaya dönebiliriz.
***** Personel Listele panelimize geldiğimizde sol üst kısımdan ID üzerine aratma ve Giriş Tarihi üzerine aratma kısımları mevcuttur. Sağ üstte şirketin Toplam maaş tutarlarını ve işçi kayıtlarının sayısını öğrenebiliriz.
****** Personelin üzerine çift tıkladığımızda altta bilgilerinin listelendiğini görebiliriz. Burada eğer personelimiz ile yollarımızın ayrıldığını varsayarsak, SİL butonundan silebiliriz. 
******* Personeli sildiğimizde dahi kayıtlarda PASİF olarak yer alacaktır. 

İletişim 
Kurulum esnasında bir problemle karşılaşmanız durumunda lütfen 10lardanur@gmail adresinden ulaşın.
Soru, öneri ve görüşleriniz için 10@lardanur@gmail.com adresine yazmaktan çekinmeyin. Mutlu Günler Dileriz.

