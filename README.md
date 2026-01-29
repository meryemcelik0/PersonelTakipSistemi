# PERSONEL YÖNETİM SİSTEMİ
Bu proje, bir Personel Yönetim Sistemi masaüstü uygulamasıdır. Uygulama, kurumlarda çalışan personelin bilgilerini, departmanlarını, izin süreçlerini, maaş ve performans değerlendirmelerini kolay ve düzenli bir şekilde yönetmek amacıyla tasarlanmıştır.
## Proje Özellikleri
**- Giriş Sistemi:** Kullanıcı adı ve şifre doğrulaması ile Role Dayalı yetkilendirme. <br/>
**- Personel İşlemleri** Personel ekleme, güncelleme, silme ve listeleme işlemleri.  <br/>
**- Departman Yönetimi:** Departman tanımlama ve yeni birim ekleme.  <br/>
**- İzin Yönetimi:** Personel izin talebi oluşturma, yönetici tarafınan izin onaylama/reddetme.  <br/>
**- Maaş İşlemleri:** Brüt maaş, prim vekesinti bilgileriyle net maaş hesaplama.  <br/>
**- Performan Değerlendirme:** Personellere puan ve yorum verilerek performans takibi. <br/>
**- Raporlama:** İzin, maaş, performans ve departman bazlı raporlar.
## Kullanılan Teknolojiler
**- C# (.NET Framework):** Uygulamanın işlevsel yapısını oluşturan ana programlama dili ve geliştirme altyapısıdır. <br/>
**- Windows Forms:** Masaüstü uygulamasının kullanıcı arayüzü tasarımında kullanılmıştır. <br/>
**- MySQL:** Uygulamada kullanılan verilerin saklandığı ilişkisel veritabanı sistemidir. <br/>
**- ADO.NET:** Uygulama ile MySQL veritabanı arasındaki bağlantıyı sağlamak için kullanılmıştır. <br/>
**- Katmanlı Mimari (DAL – BLL – UI):** Projenin daha düzenli, sürdürülebilir ve yönetilebilir olması amacıyla kullanılmıştır.
## Diyagramlar
**Use-Case Diyagramı** <br/>
<img width="737" height="505" alt="USE" src="https://github.com/user-attachments/assets/96ff2736-d179-43ee-aaa3-77a6eb9e3bf7" />

## Ekran Görüntüleri
**- Giriş Sayfası**  <br/>
<img width="476" height="405" alt="personelgiriş" src="https://github.com/user-attachments/assets/24886b29-0b3f-4dd7-a662-d4ce4c667a46" />

Kullanıcı adı ve şifre ile sisteme giriş yapılır. Kullanıcının rolüne göre yetkili olduğu ekranlara yönlendirme yapılır. <br/>
**- Ana Ekran** <br/>
<img width="1247" height="588" alt="personelanaekran" src="https://github.com/user-attachments/assets/0e2f3c17-7d61-40d5-98d6-4a0e8772b04d" />

Personel, departman, izin, maaş ve rapor işlemlerinin yönetildiği ana ekrandır. bu işlemlerin butonlarına basılarak asıl ekranlara gidilir. Rol bazlı buton görünürlüğü uygulanmıştır. <br/>
**- İzin Talep Ekranı** <br/>
<img width="808" height="564" alt="personelizin" src="https://github.com/user-attachments/assets/5563d161-9144-42e0-9935-30ef086408f9" />

Personellerin yıllık, sağlık ve mazeret izinleri için başvuru yaptığı ekrandır. Başlangıç ve bitiş taihleri seçildiğinde, hafta sonları ve resmi tatiller hariç tutularak net izin günü hesaplanır. <br/>
**- İzin Onaylama Ekranı** <br/>
<img width="802" height="504" alt="personelizinonay" src="https://github.com/user-attachments/assets/6a8f1407-3354-4e3a-87a0-63f07e0d414a" />

Yöneticilerin bekleyen izin taleplerini görüntülediği  ve onaylama/reddetme işlemlerini yaptığı ekrandır. Onaylanan izinler personelin 14 gün izin hakkından otamatik düşülür. <br/>
**- Maaş Hesaplama Ekranı** <br/>
<img width="577" height="510" alt="personelmaaş" src="https://github.com/user-attachments/assets/07bd53c5-5593-466d-b9a2-aa9eb119feb5" />

Personel seçimi yapıldıktan sonra girilen brüt maaş, prim ve kesinti bilgileri ile net maaş hesaplanır ve personelin maaş bilgisi güncellenir. <br/>
**- Departman Ekranı** <br/>
<img width="722" height="586" alt="personeldepartman" src="https://github.com/user-attachments/assets/4ce0075c-bb25-4deb-a32b-954381a689f8" />

Şirketin organizasyon yapısını düzenler. Yeni departman ekler ve mevcut departmanları anlık olarak listeler. Projeyi bilgisayarınıza indirin. <br/>
**- Personel Performans Ölçme Ekranı** <br/>
<img width="796" height="424" alt="personelperformans" src="https://github.com/user-attachments/assets/8c6c715e-0d11-4342-aae9-20e9bff7d0fa" />

Yöneticilerin personellere puan verdiği ve yorum yaptığı ekrandır. Bu puanlar daha sonra maaş primi ve terfi süreçleri için raporlanabilir. <br/>
**- Raporlama Ekranı** <br/>
<img width="1241" height="565" alt="personelrapor" src="https://github.com/user-attachments/assets/dc000af2-e8c9-4ad4-946d-75d398390c43" />

Sistemdeki tüm verilerin (maaş ödemeleri, izin dökümleri, performans puanları, departman dağılımı) toplu olarak incelenebildiği ekrandır. Bu verilerin raporları çıkartılır. <br/>
## Kullanım
1. Projeyi bilgisayarınıza indirin. <br/>
2. Visual Studio ile projeyi açın. <br/>
3. MySQL veritabanı bağlantı ayarlarını VeriTabani.cs dosyasından düzenleyin. <br/>
4. Uygulamayı çalıştırın. <br/>
5. Giriş ekranından kullanıcı bilgileriyle sisteme giriş yapın.
## Proje Yapısı 
**- DAL (Data Access Layer):** Veritabanı işlemleri. <br/>
**- BLL (Business Logic Layer):** İş kuralları ve hesaplamalar. <br/>
**- UI (User Interface):** Windows Forms arayüzleri. <br/>
**- MySQL:** Veritabanı yönetimi. <br/>
## Proje Hedefleri 
**-** Personel yönetim süreçlerini dijitalleştirmek. <br/>
**-** Rol bazlı güvenli erişim sağlamak. <br/>
**-** Kullanıcı dostu ve sade bir arayüz sunmak. <br/>
**-** İş süreçlerini daha hızlı ve düzenli hale getirme
## İletişim
Herhangi bir sorunuz veya öneriniz varsa lütfen benimle iletişime geçin: <br/>
**- Ad:** Meryem <br/>
**- Soyad:** Çelik <br/>
**- Tel no:** +90 1111111111 <br/>
**- E-posta:** meryemcelik@gmail.com
## Youtube Video
Youtube proje tanıtım videosu izlemek için ()
