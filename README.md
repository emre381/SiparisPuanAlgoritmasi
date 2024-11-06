### E-Ticaret Kullanıcı Analiz Programı

Bu program, bir e-ticaret sitesindeki kullanıcıların sipariş ve iade bilgilerini alır ve bu verilere dayalı çeşitli istatistikleri hesaplar. Program, kullanıcı bazında ve tüm kullanıcılar için ayrıntılı analizler yaparak site içi müşteri davranışlarına dair faydalı bilgiler sunar.

---

### Özellikler

1. **Veri Toplama**:
   - Kullanıcıdan **kullanıcı numarası**, **sipariş verilen ürün sayısı**, **iade edilen ürün sayısı** ve **ürünlere verilen puanların ortalaması** (1-5 arasında) bilgileri istenir.
   - Geçersiz girişlerin tekrar girilmesi sağlanır (örneğin, puanların 1-5 arasında olması zorunludur).

2. **Kullanıcı Bazlı İstatistikler**:
   - Her kullanıcı için sipariş ettiği ürünlerin satın alma oranı hesaplanır.
   - Kullanıcının ürünlere verdiği puanların ortalaması görüntülenir.
   - Kullanıcının 4 veya 5 puan verdiği ürünlerin oranı ayrıca gösterilir.

3. **Genel İstatistikler**:
   - Kullanıcı başına ortalama satın alınan ürün sayısı.
   - En az bir ürün iade eden kullanıcı yüzdesi.
   - Hiç 5 puan vermeyen kullanıcıların yüzdesi.
   - Puan ortalaması 2’den düşük olan kullanıcı oranı.
   - En çok ürün siparişi veren kullanıcıya ait detaylar (kullanıcı numarası, satın aldığı ve iade ettiği ürün sayısı, verdiği puanların ortalaması).

---

### Kullanım

1. **Programı Başlatın**:
   - Konsolda programı çalıştırın. Program kullanıcı bilgilerini istemeye başlayacaktır.

2. **Kullanıcı Bilgilerini Girin**:
   - Konsoldaki yönergeleri takip ederek, her kullanıcı için sırasıyla şu bilgileri girin:
     - **Kullanıcı Numarası**: Her kullanıcıya özel bir numara.
     - **Sipariş Verilen Ürün Sayısı**: Kullanıcının sipariş ettiği toplam ürün sayısı.
     - **İade Edilen Ürün Sayısı**: Kullanıcının sipariş ettiği ürünlerden iade ettiği ürün sayısı.
     - **Puan Ortalaması**: Kullanıcının sipariş ettiği ürünlere verdiği puanların ortalaması (1 ile 5 arasında bir değer).

3. **Diğer Kullanıcıları Ekleyin**:
   - Bir kullanıcının bilgilerini girdikten sonra, başka bir kullanıcı eklemek isteyip istemediğiniz sorulacaktır.
   - **Evet** cevabı verdiğinizde yeni bir kullanıcı bilgisi eklenebilir, **Hayır** cevabı verdiğinizde ise veri girişi sonlanır ve analizler yapılır.

4. **Analiz Sonuçlarını Görüntüleyin**:
   - Program, kullanıcı bazında ve genel istatistikleri konsola yazdırır.

---

### Örnek Çalışma

Kullanıcıdan alınan örnek girdiler:

```
Kullanıcı Numarası: 1
Sipariş Verdiği Ürün Sayısı: 5
İade Ettiği Ürün Sayısı: 2
Verdiği Puanların Ortalaması (1-5): 4.2
Başka kullanıcı var mı? (e/E/h/H): e

Kullanıcı Numarası: 2
Sipariş Verdiği Ürün Sayısı: 3
İade Ettiği Ürün Sayısı: 0
Verdiği Puanların Ortalaması (1-5): 3.7
Başka kullanıcı var mı? (e/E/h/H): h
```

Ekrana yazdırılan analiz sonuçları:

```
Kullanıcı Bazlı İstatistikler:
Kullanıcı No: 1, Satın Alma Oranı: %60.00, Verdiği Puan Ortalaması: 4.20
4 veya 5 puan verdikleri için satın alma oranı: %60.00

Kullanıcı No: 2, Satın Alma Oranı: %100.00, Verdiği Puan Ortalaması: 3.70

Genel İstatistikler:
Kullanıcı Başına Ortalama Satın Alınan Ürün Sayısı: 3.50
En az bir ürün iade eden kullanıcı oranı: %50.00
Hiç 5 puan vermeyen kullanıcı oranı: %100.00
Puan ortalaması 2’den düşük olan kullanıcı oranı: %0.00
En çok ürün alan kullanıcı no: 1, Satın Aldığı Ürün Sayısı: 3, İade Ettiği Ürün Sayısı: 2, Verdiği Puan Ortalaması: 4.20
```

---

### Geliştirme ve İyileştirme Önerileri

- **Dosya Kaydetme**: Kullanıcı verilerini ve analiz sonuçlarını bir dosyaya kaydederek ileride tekrar kullanılmasını sağlama.
- **Grafiksel Arayüz**: İstatistiklerin görsel grafiklerle gösterildiği bir arayüz ekleme.
- **Gelişmiş Analizler**: Kullanıcıların ürün tercihleri veya mevsimsel sipariş eğilimleri gibi daha ayrıntılı analizler ekleme.

---
